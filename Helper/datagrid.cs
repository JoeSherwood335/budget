using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;

namespace webistrar.TagHelpers
{
    /// <summary>
    /// <see cref="ITagHelper"/> implementation targeting &lt;datagride&gt; elements.
    /// </summary>

    [HtmlTargetElement("datagrid", Attributes = Href)]
    [HtmlTargetElement("datagrid", Attributes = aspdisabled)]
    public class datagridTagHelper : TagHelper
    {

        private const string aspdisabled = "asp-disabled";

                
        private const string Href = "href";
 
        [HtmlAttributeName(aspdisabled)]
        public string AspDisabled { get; set; }


        [HtmlAttributeName(Href)]
        public string url { get; set; }

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.TagName = (String.IsNullOrEmpty(AspDisabled)) ? "a" : "span";

            if (!output.Attributes.Any(e => e.Name == "class"))
            {

              output.Attributes.Add("class","datagrid");

            } else {

              var val = output.Attributes["class"].Value;
              output.Attributes.SetAttribute("class", $@"datagrid {val}");

            }

        } // end progress
    } // end class
} // end namespace
