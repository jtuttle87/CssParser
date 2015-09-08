using ExCSS;

namespace CssParser.Model
{
    interface ISupportsDeclarations
    {
        StyleDeclaration Declarations { get; }
    }
}