﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace alexa.dev.excuses
{
	public static class Excuses
	{
		//not normally thread safe, but multiple reads are ok, just no writes
		public static List<string> ExcuseList = new List<string>()
		{
			"Actually, that's a feature",
            "I didn't make any changes that should have broke anything",
			"Did you check for a virus on your system?",
			"Don't worry, that value is only wrong half of the time",
			"Even though it doesn't work, how does it feel?",
			"Everything looks fine my end",
			"How is that possible?",
			"That code was upvoted in stackoverflow",
			"Thats a problem with a package we depend on",
			"I broke that deliberately to do some testing",
			"I can't make that a priority right now",
			"I can't test everything",
			"I couldn't find any examples of how that can be done anywhere else in the project",
			"I couldn't find any examples of how that can be done anywhere online",
			"I couldn't find any library that can even do that",
			"I did a quick fix last time but it broke when we rebooted",
			"I didn't anticipate that I would make any errors",
			"I didn't create that part of the program",
			"I didn't receive a ticket for it",
			"I forgot to commit the code that fixes that",
			"I had to do the project backwards as people demanded results out of order",
			"I have never seen that before in my life",
			"I haven't been able to reproduce that",
			"I haven't had any experience with that before",
			"I haven't had the chance to run that code yet",
			"I haven't touched that code in weeks",
			"I have too many other high priority things to do right now",
			"I heard there was a solar flare today",
			"I'll have to fix that at a later date",
			"I'm not familiar with it so I didn't fix it in case I made it worse",
			"I'm not getting any error codes",
			"I'm not sure as I've never had a look at how that works before",
			"I'm still working on that as we speak",
			"I'm surprised it works as well as it does",
			"I'm surprised that was working at all",
			"I must have been stress testing our production server",
			"I must not have understood what you were asking for",
			"In the interest of efficiency I only check my email for that on a Friday",
			"It cannot be done and I'm not doing it",
			"It can't be broken, it passes all unit tests",
			"I thought I finished that",
			"I thought I fixed that",
			"I thought you signed off on that?",
			"It must be a firewall issue",
			"It must be a hardware problem",
			"It must be because of a leap second",
			"It must be because of a leap year",
			"I told you yesterday it would be done by the end of today",
			"It probably won't happen again",
			"It's a browser compatibility issue",
			"It's a character encoding issue",
			"It's a known bug with the programming language",
			"It's a known bug with the server software",
			"It's always been like that",
			"It's an unexpected emergent behaviour of several last minute abstractions",
			"It's a remote vendor issue",
			"It's a third party application issue",
			"It's just some unlucky coincidence",
			"It's never done that before",
			"It's never shown unexpected behaviour like this before",
			"It's not a code problem. our users need more training",
			"It was working in my head",
			"It worked yesterday",
			"It works, but it's not been tested",
			"It works for me",
			"It would have taken twice as long to build it properly",
			"It would take too long to rewrite the code from scratch",
			"I didn't write that",
			"I usually get a notification when that happens",
			"I was just fixing that",
			"I was told to stop working on that when something important came up",
			"Management insisted we wouldn't need to waste our time writing unit tests",
			"Maybe somebody forgot to pay our hosting company",
			"My time was split in a way that meant I couldn't do either project properly",
			"Nobody asked me how long it would actually take",
			"Nobody has ever complained about it",
			"No one told me so I was forced to assume which way to do that",
			"Oh, that was just a temporary fix",
			"Oh, that was only supposed to be a placeholder",
			"Oh, you said you DIDN'T want that to happen?",
			"Our code quality is no worse than anyone else in the industry",
			"Our hardware is too slow to cope with demand",
			"Our internet connection must not be working",
			"Our redundant systems must have failed as well",
			"Somebody must have changed my code",
			"Works fine on my machine",
			"Works great on my box",
			"That behaviour is in the original specification",
			"That code seemed so simple I didn't think it needed testing",
			"That code was written by the last person",
			"That error means it was successful",
			"That feature was slated for phase two",
			"That feature would be outside of the scope",
			"That important email must have been marked as spam",
			"That isn't covered by my job description",
			"That process requires human oversight that nobody was providing",
			"That's already fixed it just hasn't taken effect yet",
			"That's interesting, how did you manage to make it do that?",
			"That's not a bug it's a configuration issue",
			"That's the fault of the graphic designer",
			"That was literally a one in a million error",
			"That wasn't in the original specification",
			"That worked perfectly when I developed it",
			"That wouldn't be economically feasible",
			"The accounting department must have cancelled that subscription",
			"The client must have been hacked",
			"The client wanted it changed at the last minute",
			"We havn't changed anything in weeks",
			"It worked the last time I tried it",
			"The code is compiling",
			"Its not a bug, its a feature",
			"I thought you wanted it that way",
			"Thats on the agenda for next sprint",
			"The download must have been corrupted",
			"The existing design makes it difficult to do the right thing",
			"The marketing department made us put that there",
			"The original specification contained conflicting requirements",
			"The person responsible doesn't work here anymore",
			"The problem seems to be with our legacy software",
			"The program has never collected that information",
			"The project manager said no one would want that feature",
			"The project manager told me to do it that way",
			"There must be something strange in your data",
			"The request must have dropped some packets",
			"There's currently a problem with our hosting company",
			"There was too little data to bother with the extra functionality at the time",
			"There were too many developers working on that same thing",
			"The specifications were ambiguous",
			"The third party API is not responding",
			"The third party documentation is wrong",
			"The unit test doesn't cover that eventuality",
			"The user must not know how to use it",
			"THIS can't be the source of THAT",
			"This code was not supposed to go in to production yet",
			"This is a previously known bug you told me not to work on yet",
			"We didn't have enough time to peer review the final changes",
			"Well, at least it displays a very pretty error",
			"Well at least we know not to try that again",
			"Well done, you found my easter egg!",
			"Well, that's a first",
			"We outsourced that months ago",
			"We should have updated our software years ago",
			"We spent three months debugging it because we only had one month to build it",
			"What did I tell about using parts of the system you don't understand?",
			"What did you type in wrong to get it to crash?",
			"Where were you when the program blew up?",
			"Why do you want to do it that way?",
			"You can't use that version on your system",
			"You must be missing some of the dependencies",
			"You must have done something wrong",
			"Your browser must be caching the old content",
			"You're doing it wrong"

		};
	}
}