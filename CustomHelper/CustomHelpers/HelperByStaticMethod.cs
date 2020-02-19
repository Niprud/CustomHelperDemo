using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomHelper.CustomHelpers
{
    public static class HelperByStaticMethod
    {
        /// <summary>  
        /// This is a Helper Method For Image Element  
        /// </summary>  
        /// <param name="Source">Provide Source</param>  
        /// <param name="Alt">alt Attribute For That Image</param>  
        /// <param name="Title">Title For the Image</param>  
        /// <param name="Height">Height Attribute (By Default Height will be 128)</param>  
        /// <param name="Width">Width Attribute (By Default Width will be 128)</param>  
        /// <returns></returns>  
        
        public static string img(string source, string alt, string title, int height = 128, int width = 128)
        {
            return String.Format("<img src='{0}' alt='{1}' title='{2}' height='{3}' width='{4}'/>", source, alt, title, height, width);
        }

    }
}