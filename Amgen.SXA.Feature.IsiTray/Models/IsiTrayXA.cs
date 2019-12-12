
using Sitecore.XA.Foundation.Mvc.Models;
using System.Collections.Generic;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using System;

namespace Amgen.SXA.Feature.IsiTray.Models
{
    public class IsiTrayXA : RenderingModelBase
    {
        public ID ID { get; set; }

        public String IsiReadMoreText { get; set; }

        public String IsiReadLessText { get; set; }

        public string IsiHeading { get; set; }

        public string MaxmumMarkup { get; set; }
        public string MinimumMarkup { get; set; }

    }
}