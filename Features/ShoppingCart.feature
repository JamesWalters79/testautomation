Feature: ShoppingCart

@ui @shoppingcart @removeproduct
Scenario: Remove product from the shopping cart
	Given a "product" is added to the shopping cart
	When the shopper views the shopping cart
	And the shopper removes the "product" from the shopping cart
	Then the "product" is removed from shopping cart
	And the shopping cart is empty

Examples: Basket Products
    | parent | product   |
    | T-Shirts  | FadedShort Sleeve T-Shirt |