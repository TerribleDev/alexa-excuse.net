using AlexaSkillsKit.Speechlet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlexaSkillsKit.Authentication;
using AlexaSkillsKit.Json;
using System.Threading.Tasks;
using AlexaSkillsKit.UI;
using AngleSharp;

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
				ShouldEndSession = true;
			});
		}
		public static async Task<string> GetExcuses()
		{
			// Setup the configuration to support document loading
			var config = Configuration.Default.WithDefaultLoader();
			// Load the names of all The Big Bang Theory episodes from Wikipedia
			var rando = new Random().Next(0,2);
			string address = null;
			if (rando == 0)
			{
				address = "http://programmingexcuses.com/";
			}
			if(rando == 1)
			{
				address = "http://www.devexcuses.com/";
			}
			if(address == null)
			{
				throw new Exception("Something really wrong with the rando generator");
			}
			// Asynchronously get the document in a new context using the configuration
			var document = await BrowsingContext.New(config).OpenAsync(address);
			// This CSS selector gets the desired content
			var cellSelector = "a";
			// Perform the query to get all cells with the content
			var cells = document.QuerySelectorAll(cellSelector);
			// We are only interested in the text - select it with LINQ
			return cells.First().TextContent;
		}
	}
}