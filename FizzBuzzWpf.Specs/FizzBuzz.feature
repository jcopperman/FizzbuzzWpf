Feature: FizzBuzzNotMultiplesOf3Or5
	Given I have entered in 1 
	When I press Fizzbuzzinator 
	As a user
	I want to be told the value

@mytag
Scenario: Given1Is1
	Given I have entered 1 into the FizzBuzzApp	
	When I press Fizzbuzzinator
	Then the result should be 1 on the screen

@mytag
Scenario: Given3IsFizz
	Given I have entered 3 into the FizzBuzzApp	
	When I press Fizzbuzzinator
	Then the result should be Fizz on the screen

@mytag
Scenario: Given5IsBuzz
	Given I have entered 5 into the FizzBuzzApp	
	When I press Fizzbuzzinator
	Then the result should be Buzz on the screen

@mytag
Scenario: Given15IsFizzBuzz
	Given I have entered 15 into the FizzBuzzApp	
	When I press Fizzbuzzinator
	Then the result should be FizzBuzz on the screen


