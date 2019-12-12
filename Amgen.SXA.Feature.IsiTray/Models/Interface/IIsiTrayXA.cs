using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amgen.SXA.Feature.IsiTray.Models.Interface
{
    interface IIsiTrayXA
    {

        String IsiReadMoreText { get; set; }

        String IsiReadLessText { get; set; }

        string IsiHeading { get; set; }

        string MaxmumMarkup { get; set; }
        string MinimumMarkup { get; set; }


    }
}
