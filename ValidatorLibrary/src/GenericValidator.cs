using System.ComponentModel.DataAnnotations;

namespace ValidatorLibrary
{
    /// <summary>
    /// Represents the results of a generic validation operation.
    /// </summary>
    /// <param name="IsValid">Indicates whether the validation was successful.</param>
    /// <param name="ErrorMessages">A collection of error messages if the validation failed.</param>
    public sealed record GenericValidatorResults(bool IsValid, IEnumerable<string?> ErrorMessages);

    /// <summary>
    /// Provides methods for validating objects using data annotations.
    /// </summary>
    public static class GenericValidator
    {
        /// <summary>
        /// Validates the specified model using data annotations.
        /// </summary>
        /// <typeparam name="TModel">The type of the model to validate.</typeparam>
        /// <param name="model">The model to validate.</param>
        /// <returns>A <see cref="GenericValidatorResults"/> object containing the validation results.</returns>
        public static GenericValidatorResults Validate<TModel>(TModel model)
        {
            ValidationContext validationContext = new ValidationContext(model!);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(model!, validationContext, validationResults, true);
            return new GenericValidatorResults(isValid, validationResults.Select(vr => vr.ErrorMessage));
        }

        /// <summary>
        /// Tries to validate the specified model using data annotations.
        /// </summary>
        /// <typeparam name="TModel">The type of the model to validate.</typeparam>
        /// <param name="model">The model to validate.</param>
        /// <param name="errorMessages">When this method returns, contains a collection of error messages if the validation failed.</param>
        /// <returns><c>true</c> if the model is valid; otherwise, <c>false</c>.</returns>
        public static bool TryValidate<TModel>(TModel model, out IEnumerable<string?> errorMessages)
        {
            ValidationContext validationContext = new ValidationContext(model!);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(model!, validationContext, validationResults, true);
            errorMessages = validationResults.Select(vr => vr.ErrorMessage);
            return isValid;
        }
    }

}
