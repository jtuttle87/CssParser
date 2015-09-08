using System.Collections.Generic;
using ExCSS;

namespace CssParser.Model
{
    interface ISupportsRuleSets
    {
        List<RuleSet> RuleSets { get; }
    }
}