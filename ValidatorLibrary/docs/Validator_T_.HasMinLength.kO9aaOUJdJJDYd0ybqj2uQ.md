#### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary')
### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary').[Validator&lt;T&gt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')

## Validator<T>.HasMinLength(Func<T,string>, int, string) Method

Validates that the selected property has a minimum length.

```csharp
public ValidatorLibrary.Validator<T> HasMinLength(System.Func<T,string> propertySelector, int minLength, string errorMessage);
```
#### Parameters

<a name='ValidatorLibrary.Validator_T_.HasMinLength(System.Func_T,string_,int,string).propertySelector'></a>

`propertySelector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Validator_T_.md#ValidatorLibrary.Validator_T_.T 'ValidatorLibrary.Validator<T>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

A function to select the property to validate.

<a name='ValidatorLibrary.Validator_T_.HasMinLength(System.Func_T,string_,int,string).minLength'></a>

`minLength` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The minimum length required.

<a name='ValidatorLibrary.Validator_T_.HasMinLength(System.Func_T,string_,int,string).errorMessage'></a>

`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The error message to return if validation fails.

#### Returns
[ValidatorLibrary.Validator&lt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')[T](Validator_T_.md#ValidatorLibrary.Validator_T_.T 'ValidatorLibrary.Validator<T>.T')[&gt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')  
The current instance of MicroValidator.