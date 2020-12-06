Feature: ShoppingCart

@ui @shoppingcart @removeproduct
Scenario: Remove product from the shopping cart
	Given a "parent" "child" "grandchild" "product" is added to the shopping cart
	When the shopper views the shopping cart
	And the shopper removes the "product" from the shopping cart
	Then the "product" is removed from shopping cart
	And the shopping cart is empty

Examples: Shopping Cart Products
    | parent | child   | grandchild     | product               |
    | Women  | Dresses | Summer Dresses | Printed Chiffon Dress |
