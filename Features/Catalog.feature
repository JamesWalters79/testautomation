Feature: Catalog

@ui @catalog @viewcatalogproducts
Scenario: View summer dresses catalog products
	Given the store home page is displayed
	When the shopper views the "parent" "child" "grandchild" collection
	Then the shopper sees "product count" products in the collection

Examples: Summer Dresses
    | parent | child   | grandchild     | product count | category |
    | Women  | Dresses | Summer Dresses | 3             | 11       |


@ui @catalog @filtercatalog
Scenario: Filter by price summer dresses catalog products
	Given the store home page is displayed
	When the shopper views the "parent" "child" "grandchild" collection
	And the shopper sets the minimum price to "minimum"
	And the shopper sets the maximum price to "maximum"
	Then the shopper sees "product count" products in the collection
	And the price for each product is less than "maximum"
	And the price for eac product is greater than "minimum"

Examples: Summer Dresses
    | parent | child   | grandchild     | minimum | maximum | product count |
    | Women  | Dresses | Summer Dresses | 16      | 20      | 2             |