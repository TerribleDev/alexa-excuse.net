using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace alexa.dev.excuses.Controllers
{
	public class AlexaController : ApiController
	{
		[Route("")]
		[HttpPost]
		public Task<HttpResponseMessage> Post()
		{
			return new ExcuseResponse().GetResponseAsync(this.Request);
		}
		[Route("excuse")]
		[HttpGet]
		public Task<string> GetExcuse()
		{
			return ExcuseResponse.GetExcuses();
		}
	}
}
