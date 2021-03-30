## VBScript parser for .NET

Parses VBScript program into an abstract syntax tree.

### Example

```csharp
var parser = new Parser(@"dim s: s = ""hello"": msgbox s");
var program = parser.Parse();
```
