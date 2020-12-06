Feature: CreateAnAccount

@ui @account @createanaccount
Scenario: Create an account with valid unregistered email address
	Given the create an account page is shown for the shopper "email"
	When the shopper enters the first name "first"
	And the shopper enters the last name "last"
	And the shopper enters the password "password"
	And the shopper enters the date of birth "day" "month" "year"
	And the shopper sets the newsletters to "newsletters"
	And the shopper set the offers to "offers"
	And the shopper enters the company "company"
	And the shopper enters the address line "addressline1"
	And the shopper enters the city "city"
	And the shopper enters the state "state"
	And the shopper enters the country "country"
	And the shopper enters the zip "zip"
	And the shopper enters the info "info"
	And the shopper enters the home "home"
	And the shopper enters the mobile "mobile"
	And the shopper enters the alias "alias"
	And the shopper registers
	Then the shopper is shown the myaccount page for "accountname"
	
Examples: Valid Shoppers
| title | first | last   | email                  | password    | day | month   | year | newsletters | offers | company | addressline1	| addressline2 | city	| state			| country		| info | home | mobile | alias | zip | accountname |
| Mr    | Bob   | Fossil | bob.fossil@example.com | password123 | 12  | January | 1980 | true        | false  | Zoo     | Zoo Building  | 1 Zoo Road   | Zoo	| Zoo State		| Zoo Country	| Test Test Test	| 01223434343	| 07799766543	| Work  | BS1 7AG	| accountname |