using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHelper.CustomHelpers
{
    public static class HelpersbyExt
    {
        public static MvcHtmlString img(this HtmlHelper htmlHelper, string Source, string alt, string title, int Height = 128, int Width = 128)
        {
            var imgTag = new TagBuilder("image");
            imgTag.MergeAttribute("src", Source);
            imgTag.MergeAttribute("alt", alt);
            imgTag.MergeAttribute("title", title);
            imgTag.MergeAttribute("width", Width.ToString());
            imgTag.MergeAttribute("height", Height.ToString());

            return MvcHtmlString.Create(imgTag.ToString(TagRenderMode.SelfClosing));
        }
    }
}