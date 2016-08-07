Feature: PriceCalculation
	In order to get prices right
	As a shop owner
	I want to calculate them whether there are discounts to be applied or not

Scenario: Customer buys 1 bread, 1 butter and 1 milk
	Given the basket has
		| Quantity | Name   | Price |
		| 1        | bread  | 1.00  |
		| 1        | butter | 0.80  |
		| 1        | milk   | 1.15  |
	When I total the basket
	Then the price should be £2.95

Scenario: Customer buys 2 butter and 2 bread
	Given the basket has
		| Quantity | Name   | Price |
		| 2        | butter | 0.80  |
		| 2        | bread  | 1.00  |
	When I total the basket
	Then the price should be £3.10

Scenario: Customer buys 4 milk
	Given the basket has
		| Quantity | Name   | Price |
		| 4        | milk   | 1.15  |
	When I total the basket
	Then the price should be £3.45

Scenario: Customer buys 2 butter, 1 bread and 8 milk
	Given the basket has
		| Quantity | Name   | Price |
		| 2        | butter | 0.80  |
		| 1        | bread  | 1.00  |
		| 8        | milk   | 1.15  |
	When I total the basket
	Then the price should be £9.00
