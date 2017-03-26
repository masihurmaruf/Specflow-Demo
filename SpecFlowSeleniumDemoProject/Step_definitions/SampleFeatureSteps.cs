using System;
using SpecFlowSeleniumDemoProject;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

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

		[When(@"I fill all the mandatory datails in form")]
		public void WhenIFillAllTheMandatoryDatailsInForm(Table table)
		{
			//EmployeeDetails details = table.CreateInstance<EmployeeDetails>();

			//Console.WriteLine(details.Age);
			//Console.WriteLine(details.Name);
			//Console.WriteLine(details.Phone);
			//Console.WriteLine(details.Email);

			var details = table.CreateSet<EmployeeDetails>();

			foreach (EmployeeDetails employee in details)
			{
				Console.WriteLine("Details for Employee: " + employee.Name);
				Console.WriteLine(employee.Age);
				Console.WriteLine(employee.Name);
				Console.WriteLine(employee.Phone);
				Console.WriteLine(employee.Email);
			}

		}

	}
}




