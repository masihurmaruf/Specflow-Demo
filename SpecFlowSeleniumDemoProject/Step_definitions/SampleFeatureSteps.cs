using System;
using System.Collections.Generic;
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

		[When(@"I fill the mandatory datails in form (.*), (.*) and (.*)")]
		public void WhenIFillTheMandatoryDatailsInFormMasihurAnd(string name, int age, Int64 phone)
		{
			Console.WriteLine("Name :" + name);
			Console.WriteLine("Age :" + age);
			Console.WriteLine("Phone :" + phone);

			ScenarioContext.Current["InfoforNextStep"] = "Step 1 Passed";

			Console.WriteLine(ScenarioContext.Current["InfoforNextStep"]);

			List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
			{
				new EmployeeDetails()
				{
					Name = "Abraham",
					Age = 20,
					Email = "email@abraham.com",
					Phone = 23454322
				},

				new EmployeeDetails()
				{
					Name = "Moses",
					Age = 19,
					Email = "email@moses.com",
					Phone = 5464367638
				},

				new EmployeeDetails()
				{
					Name = "Jesus",
					Age = 18,
					Email = "email@jesus.com",
					Phone = 78987978978
				}
			};

			// Save the ScenarioContext
			ScenarioContext.Current.Add("EmpDetails", empDetails);

			//Get the value out from ScenarioContext
			var empList = ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");

			foreach (EmployeeDetails emp in empList)
			{
				Console.WriteLine("The EMployee name is : " + emp.Name);
				Console.WriteLine("The EMployee age is : " + emp.Age);
				Console.WriteLine("The EMployee email is : " + emp.Email);
				Console.WriteLine("The EMployee phone is : " + emp.Phone);

			}

			Console.WriteLine(ScenarioContext.Current.ScenarioInfo.Title);
			Console.WriteLine(ScenarioContext.Current.CurrentScenarioBlock);
			Console.WriteLine(ScenarioContext.Current.Count);

		}

	}
}




