using Sitecore.XA.Foundation.Mvc.Models;

namespace AddressValidation.PageContent.Models
{
    public class AddressRenderingModel : RenderingModelBase
    {
        public string Addressline1 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Addressline2 { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public string CSSLink { get; set; }

        public string JSLink { get; set; }

    }
}

