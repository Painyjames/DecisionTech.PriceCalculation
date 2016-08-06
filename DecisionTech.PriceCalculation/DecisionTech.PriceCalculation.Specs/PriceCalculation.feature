Feature: PriceCalculation
	In order to get prices right
	As a shop owner
	I want to calculate them whether there are discounts to be applied or not

Scenario: Customer buys 1 bread, 1 butter and 1 milk
	Given the basket has
		| Quantity | Name   |
		| 1        | bread  |
		| 1        | butter |
		| 1        | milk   |
	When I total the basket
	Then the price should be £2.95

Scenario: Customer buys 2 butter and 2 bread
	Given the basket has
		| Quantity | Name   |
		| 2        | butter |
		| 2        | bread  |
	When I total the basket
	Then the price should be £3.10

Scenario: Customer buys 4 milk
	Given the basket has
		| Quantity | Name   |
		| 4        | milk   |
	When I total the basket
	Then the price should be £3.45

Scenario: Customer buys 2 butter, 1 bread and 8 milk
	Given the basket has
		| Quantity | Name   |
		| 2        | butter |
		| 1        | bread  |
		| 8        | milk   |
	When I total the basket
	Then the price should be £9.00
