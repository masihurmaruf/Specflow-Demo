using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemoProject
{
	[Binding]
	public class SampleFeatureSteps
	{
		[Given(@"I have entered (.*) into the calculator")]
		public void GivenIHaveEnteredIntoTheCalculator(int number)
		{
			Console.WriteLine(number);
		}

		[When(@"I press add")]
		public void WhenIPressAdd()
		{
			Console.WriteLine("Pressed Add Button");
		}

		[Then(@"the result should be (.*) on the screen")]
		public void ThenTheResultShouldBeOnTheScreen(int result)
		{
			if (result == 120)
				Console.WriteLine("PASSED");
			else
			{
				Console.WriteLine("FAILED");
				throw new Exception("Result is not Correct");
			}
				
		}

	}
}




