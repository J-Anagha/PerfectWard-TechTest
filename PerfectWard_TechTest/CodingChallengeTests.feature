Feature: CodingChallengeTests

@topNavTest
Scenario: To verify that the top navigation is accessible
	When I navigate to the Home page
	Then I should be able to access following top navigation menu items
	| MenuItems      |
	| Home          |
	| Covid19(IPC)  |
	| Features      |
	| Our Solutions |
	| Resources     |
	| Contact       |
	And the Book a demo button should be available for following top navigation menu items
	| MenuItems      |
	| Home          |
	| Covid19(IPC)  |
	| Features      |
	| Our Solutions |
	| Resources     |
	| Contact       |

@errorTest
Scenario: To verify that the error message appears for a missing mandatory field
	Given I navigate to the Home page
	And I open the Contact Us page
	And I complete the contact form except the "Message" field
	When I submit the form
	Then I should receive an error message "This field is required" for the Message field
	And I should receive the error message "Sorry, there was an error submitting the form. Please try again." above the form
	