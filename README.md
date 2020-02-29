# _Bakery Orders_

#### _Epicodus Week 7 solo project, 2/28/2020_

#### By _Matt Taylor_

## Description

_This application project is an exercise in C# classes using the console. The user runs through a mock Bakery menu, inputting their purchases and checking out to receive a total._

## Behavior Driven Development
| Behavior | Input Example | Output Example |
|----|----|-----|
| User receives a prompt when running the application | ``$ dotnet run`` | Welcome message displayed with Bread and Pastry option menu |
| User selects an item type to purchase | 'B' | Prompt is displayed asking how many loaves |
| Application accepts both upper or lowercase options | b | Prompt is displayed asking how many loaves |
| User orders bread at $5 each | 'B', '2' | $10 |
| User orders pastry at $2 each | 'P', '2' | $4 |
| Application offers 'buy 2 get 1 free' discount on Bread | Buy 6  bread at $5 each | $20 total |
| Application offers discount deal on Pastry, purchasing 3 for $5 | Buy 6 pastry at $2 each | $10 total |
| Application presents a third option for rye bread with standard loaves factored in for discount | 'R', '2', 'B', '1'  | $10 |
| Menu presents option to checkout | 'C' | 6 loaves for $20, 6 pastries $10, total cost $30|
| Menu presents otion to clear order | User buys 6 loaves, 'Q' | 0 loaves for $0 |


## Setup/Installation Requirements

* Open Terminal
* Type ``$ git clone https://github.com/mtaylorpdx/bakery``
* Navigate to the project folder
* Type ``$ dotnet run``

## Support and contact details

Email [@Matt Taylor](mailto:me@email.com)

## Technologies Used

* Git
* C#
* .NET Core

### License

*Licensed under the MIT License*

Copyright (c) 2020 **_Matt Taylor_**