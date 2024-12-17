# Bull and Cows Game in C#

## Overview
This project is a simple implementation of the **Bull and Cows** game (also known as Mastermind) in **C#**. In this game, the player has to guess a secret number chosen by the computer. Each guess is evaluated based on how many digits are correct and in the correct position ("bulls") and how many digits are correct but in the wrong position ("cows").

## Features
- The game generates a secret 4-digit number.
- The player guesses a 4-digit number and receives feedback on how many "bulls" (correct digits in the correct position) and "cows" (correct digits but in the wrong position) their guess contains.
- The game continues until the player guesses the secret number correctly.
- The player can play multiple rounds.

## Requirements
- **.NET Framework** or **.NET Core** (version 5 or higher recommended).
- A **C#** compatible environment like Visual Studio or Visual Studio Code.

## Setup Instructions

### Prerequisites:
1. Install **Visual Studio** or **Visual Studio Code** (with C# extension).
2. Clone or download this repository to your local machine.

### Running the Game:
1. Open the project in your preferred C# IDE.
2. Build and run the project.
3. The game will ask for a 4-digit guess.
4. The player will be provided with feedback after each guess showing the number of bulls and cows.
5. Keep guessing until the correct number is found.



## How the Game Works
1. The game randomly generates a 4-digit number where no digits repeat.
2. The player inputs a guess. After each guess, the game provides feedback with the number of bulls and cows:
   - **Bull**: A digit that is in the correct position.
   - **Cow**: A digit that is in the wrong position but exists in the secret number.
3. The game continues until the player guesses the secret number correctly.

## Game Rules:
- The player is given feedback in terms of "bulls" (correct digits in the correct positions) and "cows" (correct digits in the wrong positions).
- The player must use the feedback to refine their guesses.
- The goal is to guess the secret number with the least number of attempts.

## Code Structure:
- **Program.cs**: Main entry point of the game.
- **Game.cs**: Contains the game logic (generating the secret number, evaluating guesses).
- **UserInterface.cs**: Handles user input and output.

## Contributing
Feel free to fork the repository, submit issues, or pull requests. Contributions are always welcome!

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
