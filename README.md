# PerfectWard-TechTest

The tests have been written is C# using .NetCore frameowrk. 

Tests are written in BDD style using Specflow and Selenium.
 
Steps to run the tests:

1) Git Clone the repository.
2) Open the solution in Visual Studio.
3) Build the project.
4) Run the tests.

Approach toward completing the challenge:

1) Since the test involves navigating to different pages on the site under test, I believe that the Page Object Model will be helpful to keep a separation between the page elements locators and the methods associated with those. There is BasePage that provides common functionality to all page objects.

2) I have chosen a Gherkin format for the test as it is easy for the stakeholders to understand the scenario in plain English and also because it was the desired format for this test.

3) I have passed the data as a table through the feature file to verify the accessibility for different menu items in the top navigation on the home page. I opted this way of data handling because if offers a flexibility to add/remove menu items to be verified. It is clearer to a third person to know exactly which menu items are getting tested for accessibility.

4) Where there was a need to keep the message field blank as a part of the test, my approach was to fill in the entire form first and then clear the field which we need to keep blank. I had added a different methods to fill in the form and to clear the field. This was we can re-use the method to fill I the form for other scenarios in future.
 
5) I have parameterized the test steps in the feature file to make those steps reusable for other scenarios if needed. It offers flexibility to the user to enter different values as needed using the same step to avoid code duplication.

Given more time I would like to implement following changes in the solution:

1) Add config file where I can specify the URLs for different pages from the PerfectWard site. This will allow parametrise the URLs of different test environments.

2) In the feature file there is a step where I fill in the Contact form but keep the Message field blank. I would like to pass the form data in the table form so that user can specify which values he wants to set for different fields. Since this was not the main focus of the test at this point, I have hard-coded the field values in the method to fill the form.

3) In order to synchronise the test in future I would like to add explicit waits for until specific page element appears/disappears.

4) Add Run Settings to run the test on different browsers. Run settings will have the configuration needed for different types of browsers.
