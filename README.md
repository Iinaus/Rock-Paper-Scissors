# Rock-Paper-Scissors Game

## Table of Contents
- [About](#about)
-   [Features](#features)
- [Prerequisites](#prerequisites)
- [How to Run](#how-to-run)
- [How to Play](#how-to-play)

## About
This is a simple **Rock-Paper-Scissors** console application written in C#. The game allows the player to compete against the computer in multiple rounds, with the computer randomly selecting its moves. The project was developed as part of the coursework for an object-oriented programming (OOP) course at Lapland University of Applied Sciences.The game follows the classic rules of rock-paper-scissors:

- Rock beats Scissors
- Paper beats Rock
- Scissors beats Paper

After each round, the result will be displayed in scoreboard. The game continues until either the player or the computer wins 3 rounds.

### Features
- User vs Computer gameplay.
- Randomized moves by the computer.
- Adding name for the player.
- Game results and scores displayed after each round.

## Prerequisites
To run the game, you will need the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or higher)

## How to Run
1. **Clone the repository**:
    ```bash
    git clone [https://github.com/your-username/rock-paper-scissors-csharp.git](https://github.com/Iinaus/Rock-Paper-Scissors.git)
    ```

2. **Navigate to the project directory**:
    ```bash
    cd rock-paper-scissors-csharp
    ```

3. **Build and run the project**:
    ```bash
    dotnet run
    ```

## How to Play
1. Upon starting the game, you will be prompted to write your name.

2. Next choose between Rock, Paper, or Scissors by typing the corresponding number:
    - **1** for Rock
    - **2** for Paper
    - **3** for Scissors

3. After each round, the result will be displayed.

4. The game automatically ends when either the player or the computer wins 3 rounds. If you wish to stop the game before reaching this point, you can exit the program by pressing Ctrl + C in the terminal.
