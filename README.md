# Price calculation exercise

Create a customer basket that allows a customer to add products and provides a total cost of the basket including applicable discounts.

# Comments

- There is a factory that returns classes that applies discounts. On a real world project those should be coming from a database and cached if possible.
- There are some unit tests that have been implemented using TDD, as you may check through previous commits.
- Specflow tests are in place to take care of the E2E testing. Implemented using BDD as you may check through previous commits.
- Haven't implemented a Command Line project because I felt tests were enough to demo that the functionality of the library was as specified.
- There is an Autofac module that, even if it's not used in the solution, it could be for all future projects dependant on the price calculation library.
- I've created a couple of releases. Those follows Semantic Versioning.
- If the discount conditions were more complicated I would have gone with a Specification pattern.
- If this would need to scale, I would have gone with a microservice architecture using a load balancing and/or service discovery tool, or a consumer of a messaging system as rabbitmq, or maybe with a distributed actor model system. The point is having several instances of the price calculation module that acts as request/response independent component.
