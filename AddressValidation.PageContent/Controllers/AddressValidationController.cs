using System.Web.Mvc;
using AddressValidation.PageContent.Repository;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace AddressValidation.PageContent.Controllers
{
    public class AddressValidationController : StandardController
    {
        protected readonly IAddressRepository AddressRepository;

        public AddressValidationController(IAddressRepository _addressRepository)
        {
            this.AddressRepository = _addressRepository;
        }

        public ActionResult ValidateAddress()
        {
            return View(this.GetModel());
        }

        protected override object GetModel()
        {
            return AddressRepository.GetModel();
        }
    }
}