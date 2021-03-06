using System;
using Remotion.ObjectBinding.BindableObject;
using Remotion.Data.DomainObjects.ObjectBinding;
using Remotion.ObjectBinding;

using $DOMAIN_ROOTNAMESPACE$;

namespace $PROJECT_ROOTNAMESPACE$
{
  public class Global : System.Web.HttpApplication
  {
    protected void Application_Start (object sender, EventArgs e)
    {
      BindableObjectProvider.GetProvider<BindableDomainObjectProviderAttribute>().AddService (
          typeof (BindableDomainObjectGetObjectService), new BindableDomainObjectGetObjectService ());

    }

    protected void Application_End (object sender, EventArgs e)
    {

    }
  }
}
