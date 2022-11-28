@setup_feature
Feature: DeleteCustomers


Scenario: removing a customer from the list
	Given open XYZ Bank page
	And click Bank Manager Login
	And click on the Customers
	When delete the client by clicking on Delete
	Then the client is removed from the list