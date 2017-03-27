using System;

using TechTalk.SpecFlow;

namespace SpecFlowSeleniumDemoProject
{
	[Binding]
	public class TestFixture
	{
		[BeforeStep]
		public void BeforeStep()
		{
			// TODO: implement logic that has to run before each scenario step
			// For storing and retrieving scenario-specific data, 
			// the instance fields of the class or the
			//     ScenarioContext.Current
			// collection can be used.
			// For storing and retrieving feature-specific data, the 
			//     FeatureContext.Current
			// collection can be used.
			// Use the attribute overload to specify tags. If tags are specified, the event 
			// handler will be executed only if any of the tags are specified for the 
			// feature or the scenario.
			//     [BeforeStep("mytag")]
			Console.WriteLine("*Before Step*");
		}

		[AfterStep]
		public void AfterStep()
		{
			// TODO: implement logic that has to run after each scenario step
			Console.WriteLine("*After Step*");
		}

		[BeforeScenarioBlock]
		public void BeforeScenarioBlock()
		{
			// TODO: implement logic that has to run before each scenario block (given-when-then)
			Console.WriteLine("*Before Scenario Block*");
		}

		[AfterScenarioBlock]
		public void AfterScenarioBlock()
		{
			// TODO: implement logic that has to run after each scenario block (given-when-then)
			Console.WriteLine("*After Sceanrio Block*");
		}

		[BeforeScenario]
		public void BeforeScenario()
		{
			// TODO: implement logic that has to run before executing each scenario
			Console.WriteLine("*Before Scenario*");
		}

		[AfterScenario]
		public void AfterScenario()
		{
			// TODO: implement logic that has to run after executing each scenario
			Console.WriteLine("*After Scenario*");
		}

		[BeforeFeature]
		public static void BeforeFeature()
		{
			// TODO: implement logic that has to run before executing each feature
			Console.WriteLine("*Before Feature*");
		}

		[AfterFeature]
		public static void AfterFeature()
		{
			// TODO: implement logic that has to run after executing each feature
			Console.WriteLine("*After Feature*");
		}

		[BeforeTestRun]
		public static void BeforeTestRun()
		{
			// TODO: implement logic that has to run before the entire test run
			Console.WriteLine("*Before Test Run*");
		}

		[AfterTestRun]
		public static void AfterTestRun()
		{
			// TODO: implement logic that has to run after the entire test run
			Console.WriteLine("*After Test Run*");
		}
	}
}
