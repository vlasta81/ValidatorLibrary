
# ValidatorLibrary

ValidatorLibrary is a .NET library that provides methods for validating objects using data annotations. It includes generic validators and custom validators for specific types.

### Classes

- **GenericValidator**: Provides methods for validating objects using data annotations.
- **GenericValidatorResults**: Represents the results of a generic validation operation.
- **Validator&lt;T&gt;**: Abstract base class for creating custom validators for a specific type.

### Usage

#### GenericValidator

```csharp
using ValidatorLibrary;
```
```csharp
var validator = new GenericValidator(); 
var results = validator.Validate(someObject);
if (results.IsValid) 
{ 
    Console.WriteLine("Object is valid."); 
} 
else 
{ 
    foreach (var error in results.Errors) 
    { 
        Console.WriteLine(error.ErrorMessage); 
    } 
}
```

#### Custom Validator

```csharp
using ValidatorLibrary;
```
```csharp
public class CustomValidator : Validator
{
    protected override bool Validate(MyType instance)
    {
        return instance.SomeProperty != null; 
    } 
}
```
```csharp
var customValidator = new CustomValidator(); 

var isValid = customValidator.Validate(someInstance);

if (isValid) 
{ 
    Console.WriteLine("Object is valid."); 
} 
else 
{ 
    Console.WriteLine("Object is invalid."); 
}
```

## License

(c) 2024 vlasta81, MIT Licence
