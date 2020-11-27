using System.Web.Mvc;
using AddressValidation.PageContent.Repository;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace AddressValidation.PageContent.Controllers
{
    public class EmailValidationController : StandardController
    {
        protected readonly IEmailRepository EmailRepository;
        public EmailValidationController(IEmailRepository _emailRepository)
        {
            this.EmailRepository = _emailRepository;
        }

        public ActionResult ValidateEmail()
        {
            return View(this.GetModel());
        }

        protected override object GetModel()
        {
            return EmailRepository.GetModel();
        }
    }
}