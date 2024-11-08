#### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary')
### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary').[Validator&lt;T&gt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')

## Validator<T>.IsTrue(Func<T,bool>, string) Method

Validates that a custom predicate is true.

```csharp
public ValidatorLibrary.Validator<T> IsTrue(System.Func<T,bool> predicate, string errorMessage);
```
#### Parameters

<a name='ValidatorLibrary.Validator_T_.IsTrue(System.Func_T,bool_,string).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Validator_T_.md#ValidatorLibrary.Validator_T_.T 'ValidatorLibrary.Validator<T>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

A function that defines the custom validation logic.

<a name='ValidatorLibrary.Validator_T_.IsTrue(System.Func_T,bool_,string).errorMessage'></a>

`errorMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The error message to return if validation fails.

#### Returns
[ValidatorLibrary.Validator&lt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')[T](Validator_T_.md#ValidatorLibrary.Validator_T_.T 'ValidatorLibrary.Validator<T>.T')[&gt;](Validator_T_.md 'ValidatorLibrary.Validator<T>')  
The current instance of MicroValidator.