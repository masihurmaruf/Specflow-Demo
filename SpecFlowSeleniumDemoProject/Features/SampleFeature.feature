Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
	
@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Create a new employee with mandatory details
	When I fill all the mandatory datails in form
	|  Name     |  Age  |   Phone   |  Email            |
	|  Masihur  |  27   | 12345678  | email@email.com   |
	|  Tamanna  |  21   | 98765432  | tamanna@email.com |
	|  Mofi     |  24   | 5674822   | email@mofi.com    |
