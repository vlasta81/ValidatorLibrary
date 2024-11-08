#### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary')
### [ValidatorLibrary](ValidatorLibrary.md 'ValidatorLibrary').[GenericValidator](GenericValidator.md 'ValidatorLibrary.GenericValidator')

## GenericValidator.TryValidate<TModel>(TModel, IEnumerable<string>) Method

Tries to validate the specified model using data annotations.

```csharp
public static bool TryValidate<TModel>(TModel model, out System.Collections.Generic.IEnumerable<string?> errorMessages);
```
#### Type parameters

<a name='ValidatorLibrary.GenericValidator.TryValidate_TModel_(TModel,System.Collections.Generic.IEnumerable_string_).TModel'></a>

`TModel`

The type of the model to validate.
#### Parameters

<a name='ValidatorLibrary.GenericValidator.TryValidate_TModel_(TModel,System.Collections.Generic.IEnumerable_string_).model'></a>

`model` [TModel](GenericValidator.TryValidate.7Pw9nMJX6d1dgyC0i58RSg.md#ValidatorLibrary.GenericValidator.TryValidate_TModel_(TModel,System.Collections.Generic.IEnumerable_string_).TModel 'ValidatorLibrary.GenericValidator.TryValidate<TModel>(TModel, System.Collections.Generic.IEnumerable<string>).TModel')

The model to validate.

<a name='ValidatorLibrary.GenericValidator.TryValidate_TModel_(TModel,System.Collections.Generic.IEnumerable_string_).errorMessages'></a>

`errorMessages` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

When this method returns, contains a collection of error messages if the validation failed.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the model is valid; otherwise, `false`.