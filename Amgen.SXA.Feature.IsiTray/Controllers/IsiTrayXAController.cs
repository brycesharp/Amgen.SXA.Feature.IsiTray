using Amgen.SXA.Feature.IsiTray.Models;

using Sitecore.DependencyInjection;
using Sitecore.XA.Foundation.Mvc.Controllers;
using System.Web.Mvc;

namespace Amgen.SXA.Feature.IsiTray.Controllers
{
    public class IsiTrayXAController : StandardController
    {
        IsiTrayXAController()
        {
            _repository = (IIsiTrayXARepository)
                ServiceLocator.ServiceProvider.GetService(typeof(IIsiTrayXARepository));
        }

        public IsiTrayXAController(IIsiTrayXARepository repository)
        {
            _repository = repository;
        }
        private readonly IIsiTrayXARepository _repository;

        protected override object GetModel()
        {
            if ( _repository == null)
            {
                return null;
            }

            return _repository.GetModel();
        }

        override public ActionResult Index()
        {
            return PartialView(GetModel());
        }
    }
}