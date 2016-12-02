using AlexaSkillsKit.Speechlet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlexaSkillsKit.Authentication;
using AlexaSkillsKit.Json;
using System.Threading.Tasks;
using AlexaSkillsKit.UI;

namespace alexa.dev.excuses
{
	public class ExcuseResponse : SpeechletAsync
	{
		

		public override Task<SpeechletResponse> OnIntentAsync(IntentRequest intentRequest, Session session)
		{
			return CompileResponse();
		}

		public override Task<SpeechletResponse> OnLaunchAsync(LaunchRequest launchRequest, Session session)
		{
			return CompileResponse();
		}

		public override Task OnSessionEndedAsync(SessionEndedRequest sessionEndedRequest, Session session)
		{
			return Task.FromResult(0);
		}

		public override Task OnSessionStartedAsync(SessionStartedRequest sessionStartedRequest, Session session)
		{
			return Task.FromResult(0);
		}
		public Task<SpeechletResponse> CompileResponse()
		{
			return GetExcuses().ContinueWith(a =>
			new SpeechletResponse()
			{
				OutputSpeech = new PlainTextOutputSpeech() { Text = a.GetAwaiter().GetResult() },
				ShouldEndSession = true
			});
		}
		public static async Task<string> GetExcuses()
		{
			// Setup the configuration to support document loading
			var item = new Random().Next(0, Excuses.ExcuseList.Count);
			return Excuses.ExcuseList[item];
		}
	}
}