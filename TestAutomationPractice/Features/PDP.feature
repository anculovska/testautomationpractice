Feature: PDP
	In order to buy products
	As a user
	I want to be able to interact with product details
	
@mytag
Scenario: User can add product to cart
	Given user opens 'Dresses' section
	And opens first product from the list
	And increases quantity to 2
	When user clicks on add to cart button
	And user proceeds to checkout
	Then cart summary is displayed and product is added to cart 
