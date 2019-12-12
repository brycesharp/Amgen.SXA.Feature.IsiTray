using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;
using Sitecore.XA.Foundation.Variants.Abstractions.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amgen.SXA.Feature.IsiTray.Models
{
    public class IsiTrayXARepository : ModelRepository, IIsiTrayXARepository
    {


        Item componentDataSource { get; set; }
        public override IRenderingModelBase GetModel()
        {

            IsiTrayXA ixa = new IsiTrayXA();
            FillBaseProperties(ixa);

            string guid = RenderingContext.CurrentOrNull.Rendering.DataSource;
            if (guid != null && guid != "")
            {
                componentDataSource = Context.Database.GetItem(guid);
                
                if (componentDataSource.TemplateID.Equals(IsiTrayTemplates.IsiTrayTemplate))
                {
                    ixa.IsiReadLessText = GetReadLessText();
                    ixa.IsiReadMoreText = GetReadMoreText();
                    ixa.ID = GetID();
                    ixa.IsiHeading = GetIsiHeading();
                    ixa.MaxmumMarkup = GetMaximumMarkup();
                    ixa.MinimumMarkup = GetMinimumMarkup();
                }
            }

            return ixa;

        }

        private string GetIsiHeading()
        {
            return componentDataSource[IsiTrayTemplates.IsiHeading];
        }

        private string GetMaximumMarkup()
        {
            return componentDataSource[IsiTrayTemplates.IsiMaximumMarkup];
        }
        private string GetMinimumMarkup()
        {
            return componentDataSource[IsiTrayTemplates.IsiMinimumMarkup];
        }

        private string GetReadLessText()
        {
            return componentDataSource[IsiTrayTemplates.IsiReadLessText];
        }

        private string GetReadMoreText()
        {
            return componentDataSource[IsiTrayTemplates.IsiReadMoreText];
        }


        private ID GetID()
        {
            return componentDataSource.ID;
        }

    }
}