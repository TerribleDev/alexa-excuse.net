using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace alexa.dev.excuses
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		public static TelemetryClient telemetry = new TelemetryClient() { InstrumentationKey = "69bdd5ac-c992-4daa-89c9-7af1dbd09249" };
		protected void Application_Start()
		{
			GlobalConfiguration.Configure(WebApiConfig.Register);
		}
	}
}
