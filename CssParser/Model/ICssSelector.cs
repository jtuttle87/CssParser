using ExCSS;

namespace CssParser.Model
{
    interface ISupportsSelector
    {
        BaseSelector Selector { get; set; }
    }
}