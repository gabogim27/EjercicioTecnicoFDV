# Ejercicio Tecnico FDV .NET

Context
A company rents bikes under following options:

1. Rental by hour, charging $5 per hour
2. Rental by day, charging $20 a day
3. Rental by week, changing $60 a week
4. Family Rental, is a promotion that can include from 3 to 5 Rentals (of any type) with a discount of 30% of the total price

# Assigment:
1. Implement a set of classes to model this domain and logic
2. Add automated tests to ensure a coverage over 85%
3. Use GitHub to store and version your code
4. Apply all the recommended practices you would use in a real project
5. Add a README.md file to the root of your repository to explain: your design, the development practices you applied and how run the tests.

Note: we don't expect any kind of application, just a set of classes with its automated tests.

# Deliverables:
The link to your repository 

## Installation

Use Git to clone the repository.

```bash
git clone https://github.com/gabogim27/EjercicioTecnicoFDV.git
```

## Usage


Open solution (EjercicioTecnicoFDV.sln) when VisualStudio is open, build the solution then open test explorer and press on run all.

## Design

The solution is divided in two projects: 

1 - EjericioTecnicoFDV
2 - EjericioTecnicoFDV.Test

I implemented an interface (IRental) to define a group of methods that my abstract class (Rental) should implement. I created three concrete classes (HourRent, DayRent, WeekRent and FamilyRent) that inherit from Rental class. Each of them overrides the following methods: SetRentedPeriod() and CalculateRent(). In addition, I created a custom exception class that is: FamilyRentException.

# Development Practices

* I used camelcase for all members.
* I wrote one declaration per line in order to make the code easier to read.
* I idented all the lines in all the classes.
* I used lambda experssion in some tests.
* I used implicit typing for local variables. 
* I used && and || operators by skipping unnecessary comparisons.
* I used constants in order to avoid code repetion.
* I used object initializer.

# Tests

Tests have a coverage of 93%. In order to get the same result you should use "Unit Test Coverage" from Resharper.


