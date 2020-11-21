Feature: Basket

@ui @basket @removeproduct
Scenario: Remove product from the basket
	Given a "product" is added to the basket
	When the shopper views the basket
	And the shopper removes the "product" from the basket
	Then the "product" is removed from basket
	And the basket is empty

Examples: Basket Products
    | product   |
    | shirt		|