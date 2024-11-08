#### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary')
### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary').[Validator&lt;T&gt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')

## Validator<T>.IsNotNullOrEmpty(Func<T,string>, string) Method

Validates that the selected property is not null or empty.

```csharp
public ValidatorLibrary.Validator<T> IsNotNullOrEmpty(System.Func<T,string> propertySelector, string errorMessage);
```
#### Parameters

<a name='ValidatorLibrary.Validator_T_.IsNotNullOrEmpty(System.Func_T,string_,string).propertySelector'></a>

`propertySelector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Validator_T_.md#ValidatorLibrary.Validator_T_.T 'ValidatorLibrary.Validator<T>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

A function to select the property to validate.

<a name='ValidatorLibrary.Validator_T_.IsNotNullOrEmpty(System.Func_T,string_,string).errorMessage'></a>

`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The error message to return if validation fails.

#### Returns
[ValidatorLibrary.Validator&lt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')[T](Validator_T_.md#ValidatorLibrary.Validator_T_.T 'ValidatorLibrary.Validator<T>.T')[&gt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')  
The current instance of MicroValidator.