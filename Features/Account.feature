Feature: Account

@ui @account @createnewaccount
Scenario: Create a new account with valid unregistered email address
	Given the store authentication page is displayed
	When the shopper enters "email" address

Examples: Valid Shoppers
| title | first | last   | email                  | password    | DOB       | newsletters | offers | company | address    | city     | state     | country    | info           | home        | mobile      | alias |
| Mr    | Bob   | Fossil | bob.fossil@example.com | password123 | 12-1-1980 | true        | false  | Zoo     | 1 Zoo Road | Zoo Town | Zoo State | Zoo County | Test Test Test | 01223434343 | 07799766543 | Work  |

Scenario: Create a new account with invalid email address
	Given the store authentication page is displayed