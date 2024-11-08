#### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary')
### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary')

## Validator<T> Class

Abstract base class for creating custom validators for a specific type.

```csharp
public abstract class Validator<T>
```
#### Type parameters

<a name='ValidatorLibrary.Validator_T_.T'></a>

`T`

The type of the object to be validated.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Validator<T>

| Constructors | |
| :--- | :--- |
| [Validator(T)](Validator_T_..ctor.f7mW2+IDDACXGukGiT6WNg.md 'ValidatorLibrary.Validator<T>.Validator(T)') | Initializes a new instance of the [Validator&lt;T&gt;](Validator_T_.md 'ValidatorLibrary.Validator<T>') class with the specified data. |

| Methods | |
| :--- | :--- |
| [DefineRules()](Validator_T_.DefineRules().md 'ValidatorLibrary.Validator<T>.DefineRules()') | Defines the validation rules. This method must be implemented in derived classes. |
| [GetErrors()](Validator_T_.GetErrors().md 'ValidatorLibrary.Validator<T>.GetErrors()') | Gets the list of error messages for the failed validations. |
| [HasMinLength(Func&lt;T,string&gt;, int, string)](Validator_T_.HasMinLength.kO9aaOUJdJJDYd0ybqj2uQ.md 'ValidatorLibrary.Validator<T>.HasMinLength(System.Func<T,string>, int, string)') | Validates that the selected property has a minimum length. |
| [HasMinValue(Func&lt;T,IComparable&gt;, IComparable, string)](Validator_T_.HasMinValue.V9nRpt9XF/tkrt33By815Q.md 'ValidatorLibrary.Validator<T>.HasMinValue(System.Func<T,System.IComparable>, System.IComparable, string)') | Validates that the selected property has a minimum value. |
| [IsNotNullOrEmpty(Func&lt;T,string&gt;, string)](Validator_T_.IsNotNullOrEmpty.7so0oCpawbmHLp8CV0Ji4g.md 'ValidatorLibrary.Validator<T>.IsNotNullOrEmpty(System.Func<T,string>, string)') | Validates that the selected property is not null or empty. |
| [IsTrue(Func&lt;T,bool&gt;, string)](Validator_T_.IsTrue.+E6oo6Klo5O2PpaXH+IVGA.md 'ValidatorLibrary.Validator<T>.IsTrue(System.Func<T,bool>, string)') | Validates that a custom predicate is true. |
| [IsValid()](Validator_T_.IsValid().md 'ValidatorLibrary.Validator<T>.IsValid()') | Determines whether the data is valid based on the defined rules. |
| [IsValidEmail(Func&lt;T,string&gt;, string)](Validator_T_.IsValidEmail.2pXR1NEhQrAz44o2nd05/w.md 'ValidatorLibrary.Validator<T>.IsValidEmail(System.Func<T,string>, string)') | Validates that the selected property is a valid email address. |
| [IsValidPhone(Func&lt;T,string&gt;, string)](Validator_T_.IsValidPhone.IBoqiQEs0XMz6D/ZU4b+OQ.md 'ValidatorLibrary.Validator<T>.IsValidPhone(System.Func<T,string>, string)') | Validates that the selected property is a valid phone number. |
| [Matches(Func&lt;T,string&gt;, string, string)](Validator_T_.Matches.5FGhffmaz3A51FzoyJD+3A.md 'ValidatorLibrary.Validator<T>.Matches(System.Func<T,string>, string, string)') | Validates that the selected property matches a specified pattern. |
