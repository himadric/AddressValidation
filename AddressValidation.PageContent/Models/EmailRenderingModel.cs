using Sitecore.XA.Foundation.Mvc.Models;

namespace AddressValidation.PageContent.Models
{
    public class EmailRenderingModel : RenderingModelBase
    {
        public string Email { get; set; }

        public string CSSLink { get; set; }

        public string JSLink { get; set; }
    }
}