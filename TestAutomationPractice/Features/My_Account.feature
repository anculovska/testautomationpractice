Feature: MyAccount
	In order to use all functionalities
	As a user
	I want to be able to manage my account
	

	
@mytag
	Scenario: User can log in
	Given user opens sign in page
	And enters correct credentials
	When user submits the login form
	Then user will be logged in


	Scenario: User can create an account
	Given user opens sign in page
	And initiates a flow for creating an account
	And user enters all required personal details
	When user submits the sign up form
	Then user will be logged in
	And user's full name is displayed 