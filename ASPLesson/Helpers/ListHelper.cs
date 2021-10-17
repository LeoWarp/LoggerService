using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPLesson.Helpers
{
    public static class ListHelper
    {
        public static HtmlString CreateParagraph(this IHtmlHelper html, string text)
        {
            var result = $"<h2>{text}</h2>";
            return new HtmlString(result);
        }
        
        public static HtmlString CreateList(this IHtmlHelper html, string[] cars)
        {
            var result = "<select>";
            foreach (string item in cars)
            {
                result = $"{result}<option>{item}</option>";
            }
            result = $"{result}</select>";
            return new HtmlString(result);
        }
    }
}