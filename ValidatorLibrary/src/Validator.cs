
namespace ValidatorLibrary
{
    /// <summary>
    /// Abstract base class for creating custom validators for a specific type.
    /// </summary>
    /// <typeparam name="T">The type of the object to be validated.</typeparam>
    public abstract partial class Validator<T>
    {
        private T _data;
        private List<(Func<T, bool> Rule, string ErrorMessage)> _validations = new List<(Func<T, bool>, string)>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Validator{T}"/> class with the specified data.
        /// </summary>
        /// <param name="data">The data to be validated.</param>
        public Validator(T data)
        {
            _data = data;
            DefineRules();
        }

        /// <summary>
        /// Adds a validation rule to the validator.
        /// </summary>
        /// <param name="rule">The validation rule as a function that returns a boolean.</param>
        /// <param name="errorMessage">The error message to return if the validation fails.</param>
        /// <returns>The current instance of <see cref="Validator{T}"/>.</returns>
        private Validator<T> AddRule(Func<T, bool> rule, string errorMessage)
        {
            _validations.Add((rule, errorMessage));
            return this;
        }

        /// <summary>
        /// Determines whether the data is valid based on the defined rules.
        /// </summary>
        /// <returns><c>true</c> if the data is valid; otherwise, <c>false</c>.</returns>
        public bool IsValid()
        {
            return _validations.TrueForAll(v => v.Rule(_data));
        }

        /// <summary>
        /// Gets the list of error messages for the failed validations.
        /// </summary>
        /// <returns>A list of error messages.</returns>
        public List<string> GetErrors()
        {
            return _validations.FindAll(v => !v.Rule(_data)).ConvertAll(v => v.ErrorMessage);
        }

        /// <summary>
        /// Defines the validation rules. This method must be implemented in derived classes.
        /// </summary>
        protected abstract void DefineRules();
    }

}
