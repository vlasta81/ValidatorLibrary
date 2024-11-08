#### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary')
### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary').[GenericValidatorResults](GenericValidatorResults.md 'ValidatorLibrary.GenericValidatorResults')

## GenericValidatorResults(bool, IEnumerable<string>) Constructor

Represents the results of a generic validation operation.

```csharp
public GenericValidatorResults(bool IsValid, System.Collections.Generic.IEnumerable<string?> ErrorMessages);
```
#### Parameters

<a name='ValidatorLibrary.GenericValidatorResults.GenericValidatorResults(bool,System.Collections.Generic.IEnumerable_string_).IsValid'></a>

`IsValid` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Indicates whether the validation was successful.

<a name='ValidatorLibrary.GenericValidatorResults.GenericValidatorResults(bool,System.Collections.Generic.IEnumerable_string_).ErrorMessages'></a>

`ErrorMessages` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

A collection of error messages if the validation failed.