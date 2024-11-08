using System.Text.RegularExpressions;

namespace ValidatorLibrary
{
    partial class Validator<T>
    {
        /// <summary>
        /// Validates that the selected property is not null or empty.
        /// </summary>
        /// <param name="propertySelector">A function to select the property to validate.</param>
        /// <param name="errorMessage">The error message to return if validation fails.</param>
        /// <returns>The current instance of MicroValidator.</returns>
        public Validator<T> IsNotNullOrEmpty(Func<T, string> propertySelector, string errorMessage)
        {
            return AddRule(data => !string.IsNullOrEmpty(propertySelector(data)), errorMessage);
        }

        /// <summary>
        /// Validates that the selected property has a minimum length.
        /// </summary>
        /// <param name="propertySelector">A function to select the property to validate.</param>
        /// <param name="minLength">The minimum length required.</param>
        /// <param name="errorMessage">The error message to return if validation fails.</param>
        /// <returns>The current instance of MicroValidator.</returns>
        public Validator<T> HasMinLength(Func<T, string> propertySelector, int minLength, string errorMessage)
        {
            return AddRule(data => propertySelector(data)?.Length >= minLength, errorMessage);
        }

        /// <summary>
        /// Validates that the selected property has a minimum value.
        /// </summary>
        /// <param name="propertySelector">A function to select the property to validate.</param>
        /// <param name="minValue">The minimum value required.</param>
        /// <param name="errorMessage">The error message to return if validation fails.</param>
        /// <returns>The current instance of MicroValidator.</returns>
        public Validator<T> HasMinValue(Func<T, IComparable> propertySelector, IComparable minValue, string errorMessage)
        {
            return AddRule(data => propertySelector(data).CompareTo(minValue) >= 0, errorMessage);
        }

        /// <summary>
        /// Validates that the selected property is a valid email address.
        /// </summary>
        /// <param name="propertySelector">A function to select the property to validate.</param>
        /// <param name="errorMessage">The error message to return if validation fails.</param>
        /// <returns>The current instance of MicroValidator.</returns>
        public Validator<T> IsValidEmail(Func<T, string> propertySelector, string errorMessage)
        {
            return AddRule(data => Regex.IsMatch(propertySelector(data) ?? string.Empty, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"), errorMessage);
        }

        /// <summary>
        /// Validates that the selected property is a valid phone number.
        /// </summary>
        /// <param name="propertySelector">A function to select the property to validate.</param>
        /// <param name="errorMessage">The error message to return if validation fails.</param>
        /// <returns>The current instance of MicroValidator.</returns>
        public Validator<T> IsValidPhone(Func<T, string> propertySelector, string errorMessage)
        {
            return AddRule(data => Regex.IsMatch(propertySelector(data) ?? string.Empty, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$"), errorMessage);
        }

        /// <summary>
        /// Validates that the selected property matches a specified pattern.
        /// </summary>
        /// <param name="propertySelector">A function to select the property to validate.</param>
        /// <param name="pattern">The regex pattern to match.</param>
        /// <param name="errorMessage">The error message to return if validation fails.</param>
        /// <returns>The current instance of MicroValidator.</returns>
        public Validator<T> Matches(Func<T, string> propertySelector, string pattern, string errorMessage)
        {
            return AddRule(data => Regex.IsMatch(propertySelector(data) ?? string.Empty, pattern), errorMessage);
        }

        /// <summary>
        /// Validates that a custom predicate is true.
        /// </summary>
        /// <param name="predicate">A function that defines the custom validation logic.</param>
        /// <param name="errorMessage">The error message to return if validation fails.</param>
        /// <returns>The current instance of MicroValidator.</returns>
        public Validator<T> IsTrue(Func<T, bool> predicate, string errorMessage)
        {
            return AddRule(predicate, errorMessage);
        }
    }

}
