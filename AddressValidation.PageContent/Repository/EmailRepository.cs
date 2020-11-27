using AddressValidation.PageContent.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace AddressValidation.PageContent.Repository
{
    public class EmailRepository : ModelRepository, IEmailRepository
    {
        public override IRenderingModelBase GetModel()
        {
            EmailRenderingModel validateRenderingModel = new EmailRenderingModel();
            FillBaseProperties(validateRenderingModel);
            validateRenderingModel.Email = GetFieldValue(validateRenderingModel, "Email");
            validateRenderingModel.CSSLink = GetFieldValue(validateRenderingModel, "CSS file link");
            validateRenderingModel.JSLink = GetFieldValue(validateRenderingModel, "JS file link");
            return validateRenderingModel;
        }

        private string GetFieldValue(EmailRenderingModel model, string FieldName)
        {
            Sitecore.Data.Fields.Field text = model.Item.Fields[FieldName];
            return text.Value;
        }
    }
}