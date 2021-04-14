using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intex2021FagElGamous.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Intex2021FagElGamous.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-info")]

    public class PaginationTagHelper : TagHelper
    {
        private IUrlHelperFactory urlInfo;

        public PaginationTagHelper(IUrlHelperFactory uhf)
        {
            urlInfo = uhf;
        }

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public PageNumberingInfo PageInfo { get; set; }

        //public string TeamName { get; set; }

        // Dictionary that we are creating
        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> KeyValuePairs { get; set; } = new Dictionary<string, object>();

        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlInfo.GetUrlHelper(ViewContext);

            TagBuilder finishedTag = new TagBuilder("div");

            for (int i = 1; i <= PageInfo.NumPages; i++)
            {
                if (i <= 2 || PageInfo.NumPages - i < 2 || Math.Abs(PageInfo.CurrentPage - i) < 2)
                {
                    TagBuilder individualTag = new TagBuilder("a");

                    KeyValuePairs["pageNum"] = i;

                    individualTag.Attributes["href"] = urlHelper.Action("ViewBurials", KeyValuePairs);


                    if (PageClassesEnabled)
                    {
                        individualTag.AddCssClass(PageClass);
                        individualTag.AddCssClass(i == PageInfo.CurrentPage
                            ? PageClassSelected : PageClassNormal);
                    }


                    individualTag.InnerHtml.Append(i.ToString());
                    finishedTag.InnerHtml.AppendHtml(individualTag);
                }
            }

            output.Content.AppendHtml(finishedTag.InnerHtml);
        }
    }
}
