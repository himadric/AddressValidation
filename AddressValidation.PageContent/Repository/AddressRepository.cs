using AddressValidation.PageContent.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace AddressValidation.PageContent.Repository
{
    public class AddressRepository : ModelRepository, IAddressRepository
    {
        public override IRenderingModelBase GetModel()
        {
            AddressRenderingModel validateRenderingModel = new AddressRenderingModel();
            FillBaseProperties(validateRenderingModel);
            validateRenderingModel.Addressline1 = GetFieldValue(validateRenderingModel, "Address line 1");
            validateRenderingModel.Addressline2 = GetFieldValue(validateRenderingModel, "Address line 2");
            validateRenderingModel.City = GetFieldValue(validateRenderingModel, "City");
            validateRenderingModel.State = GetFieldValue(validateRenderingModel, "State");
            validateRenderingModel.ZipCode = GetFieldValue(validateRenderingModel, "ZipCode");
            validateRenderingModel.Country = GetFieldValue(validateRenderingModel, "Country");

            validateRenderingModel.CSSLink = GetFieldValue(validateRenderingModel, "CSS file link");
            validateRenderingModel.JSLink = GetFieldValue(validateRenderingModel, "JS file link");

            return validateRenderingModel;
        }

        private string GetFieldValue(AddressRenderingModel model, string FieldName)
        {
            Sitecore.Data.Fields.Field text = model.Item.Fields[FieldName];
            return text.Value;
        }
    }
}