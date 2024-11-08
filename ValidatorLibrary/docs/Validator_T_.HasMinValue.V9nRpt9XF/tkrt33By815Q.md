#### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary')
### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary').[Validator&lt;T&gt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')

## Validator<T>.HasMinValue(Func<T,IComparable>, IComparable, string) Method

Validates that the selected property has a minimum value.

```csharp
public ValidatorLibrary.Validator<T> HasMinValue(System.Func<T,System.IComparable> propertySelector, System.IComparable minValue, string errorMessage);
```
#### Parameters

<a name='ValidatorLibrary.Validator_T_.HasMinValue(System.Func_T,System.IComparable_,System.IComparable,string).propertySelector'></a>

`propertySelector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Validator_T_.md#ValidatorLibrary.Validator_T_.T 'ValidatorLibrary.Validator<T>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

A function to select the property to validate.

<a name='ValidatorLibrary.Validator_T_.HasMinValue(System.Func_T,System.IComparable_,System.IComparable,string).minValue'></a>

`minValue` [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable')

The minimum value required.

<a name='ValidatorLibrary.Validator_T_.HasMinValue(System.Func_T,System.IComparable_,System.IComparable,string).errorMessage'></a>

`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The error message to return if validation fails.

#### Returns
[ValidatorLibrary.Validator&lt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')[T](Validator_T_.md#ValidatorLibrary.Validator_T_.T 'ValidatorLibrary.Validator<T>.T')[&gt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')  
The current instance of MicroValidator.