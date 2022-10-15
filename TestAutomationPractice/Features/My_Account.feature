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