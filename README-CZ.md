
# ValidatorLibrary

ValidatorLibrary je .NET knihovna, která poskytuje metody pro validaci objektů pomocí datových anotací. Obsahuje generické validátory a vlastní validátory pro specifické typy.

### Třídy

- **GenericValidator**: Poskytuje metody pro validaci objektů pomocí datových anotací.
- **GenericValidatorResults**: Reprezentuje výsledky generické validační operace.
- **Validator&lt;T&gt;**: Abstraktní základní třída pro vytváření vlastních validátorů pro specifický typ.

### Použití

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

#### Vlastní validator

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

## Licence

(c) 2024 vlasta81, MIT Licence