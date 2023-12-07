using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MvcUI.Models;

namespace MvcUI.Infrastructure.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PaginationTagHelper : TagHelper
    {
        private readonly IUrlHelperFactory _urlHelperFactory;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext? ViewContext { get; set; }
        public Pagination PageModel { get; set; }
        public string? PageAction { get; set; }

        public PaginationTagHelper(IUrlHelperFactory urlHelperFactory)
        {
            _urlHelperFactory = urlHelperFactory;
        }
        /*
        <div class="row">
               <div class="col-5">
                   <div class="custom-pagination">
                       <a href="#">1</a>
                       <span>2</span>
                       <a href="#">3</a>
                       <a href="#">4</a>
                       <a href="#">5</a>
                   </div>
               </div>
           </div>
        */
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (ViewContext is not null && PageModel is not null)
            {
                IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
                TagBuilder row = new TagBuilder("div");
                row.Attributes.Add("class", "row");

                TagBuilder col = new TagBuilder("div");
                col.Attributes.Add("class", "col-5");

                TagBuilder pagination = new TagBuilder("div");
                pagination.Attributes.Add("class", "custom-pagination ");

                for (int i = 1; i <= PageModel.TotalPages; i++)
                {
                    TagBuilder a = new TagBuilder("a");
                    a.AddCssClass("page-item mx-1");


                    a.Attributes["href"] = urlHelper.Action(PageAction, new { PageNumber = i });
                    a.AddCssClass(i == PageModel.CurrentPage ? " active" : "");
                    a.InnerHtml.AppendHtml(i.ToString());
                    pagination.InnerHtml.AppendHtml(a);
                }
                col.InnerHtml.AppendHtml(pagination);
                row.InnerHtml.AppendHtml(col);
                output.Content.AppendHtml(row);
            }
        }
    }
}