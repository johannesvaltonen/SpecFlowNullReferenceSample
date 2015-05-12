Feature: NullReference

Scenario: Set and retrieve null value
	Given I set null value to ScenarioContext
	When I get value from ScenarioContext
	Then the value should be null