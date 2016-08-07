# Price calculation exercise

Create a customer basket that allows a customer to add products and provides a total cost of the basket including applicable discounts.

# Comments

- There is a factory that returns classes that applies discounts. On a real world project those should be coming from a database and cached if possible.
- There are some unit tests that have been implemented using TDD, as you may check through previous commits.
- Specflow tests are in place to take care of the E2E testing. Implemented using BDD as you may check through previous commits.
- Haven't implemented a Command Line project because I felt tests where enough to demo that the functionality of the library was as specified.
- There is an Autofac module that, even if it's not used in the solution, it could be for all future projects dependant on the price calculation library.
