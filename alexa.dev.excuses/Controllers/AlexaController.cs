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
		[HttpGet]
		public IHttpActionResult root()
		{
			return this.Ok("Yo");
		}
		[Route("")]
		[HttpPost]
		public HttpResponseMessage Post()
		{
			return new ExcuseResponse().GetResponse(this.Request);
		}
		[Route("excuse")]
		[HttpGet]
		public string GetExcuse()
		{
			return ExcuseResponse.GetExcuse();
		}
	}
}
