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
	public class ExcuseResponse : Speechlet
	{
		

		public override SpeechletResponse OnIntent(IntentRequest intentRequest, Session session)
		{
			return CompileResponse();
		}

		public override SpeechletResponse OnLaunch(LaunchRequest launchRequest, Session session)
		{
			return CompileResponse();
		}

		public override void OnSessionEnded(SessionEndedRequest sessionEndedRequest, Session session)
		{
		}

		public override void OnSessionStarted(SessionStartedRequest sessionStartedRequest, Session session)
		{
		}
		public static SpeechletResponse CompileResponse()
		{
			var excuse = GetExcuse();
			return new SpeechletResponse()
			{
				OutputSpeech = new PlainTextOutputSpeech() { Text = excuse },
				ShouldEndSession = true
			};
		}
		public static string GetExcuse()
		{
			// Setup the configuration to support document loading
			var item = new Random().Next(0, Excuses.ExcuseList.Count);
			return Excuses.ExcuseList[item];
		}
	}
}