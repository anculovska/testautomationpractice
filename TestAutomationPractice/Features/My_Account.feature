Feature: MyAccount
	In order to use all functionalities
	As a user
	I want to be able to manage my account
	
Background:
Given user opens sign in page
	
@mytag
	Scenario: User can log in
	And enters correct credentials
	When user submits the login form
	Then user will be logged in


	Scenario: User can create an account
	And initiates a flow for creating an account
	And user enters all required personal details
	When user submits the sign up form
	Then user will be logged in
	And user's full name is displayed


	Scenario: User can update last name 
	And enters correct credentials
	And user submits the login form
	And user opens MY PERSONAL INFORMATION
	When user enters new last name
	And enters current password
	And save the changes 
	Then last name is updated