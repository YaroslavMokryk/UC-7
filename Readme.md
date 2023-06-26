#UC_7.Tests Documentation
This repository contains a comprehensive suite of tests for the classes StudentConverter and PlayerAnalyzer within the namespace UC_7. These tests ensure the expected behavior of the classes and their methods under a variety of conditions, as well as their ability to handle edge cases and exceptional scenarios.

##StudentConverter Tests
The StudentConverter class has a method ConvertStudents() that takes in a list of Student objects and returns a modified list of Student objects, with additional properties set based on their Grade and Age. The method is covered by six tests, which verify its behavior under normal operation, boundary cases, and edge cases, including handling of null inputs. These tests ensure that the method correctly sets properties such as Exceptional, HonorRoll, Passed, and also validates its response when an empty list or a null value is passed.

##PlayerAnalyzer Tests
The PlayerAnalyzer class has a method CalculateScore() that takes in a list of Player objects and calculates a score based on each player's Age, Experience, and Skills. The method is covered by six tests which verify the score calculation for normal players, junior players, senior players, multiple players, and also check its behavior when an empty list or a player with null Skills is passed. These tests ensure that the method correctly calculates scores and can handle exceptional scenarios, including handling of null inputs.

##Running the tests locally
To run these tests locally, you need to follow these steps:

- Clone this repository to your local machine.
- Ensure that you have .NET Core installed (version 3.1 or later is recommended).
- Open a terminal and navigate to the project directory.
- Use the command dotnet test to run the tests. The output will show the results of each test.
