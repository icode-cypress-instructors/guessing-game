# Guessing Game

## About

This game is a simple guessing game where the user tries to guess a secret number.
The computer will give hints to the user if the secret number is higher or lower than the guess.

## Requirements

1. Ask the player what the lowest and highest possible secret number should be. Store the limits in variables called `lowest` and `highest`.
2. Generate a random number from `lowest` to `highest` called `secret`.
3. Read a guess from the player and tell them if the secret number is higher or lower than the guess.
4. Repeat step 4 until the player guesses the secret number.
5. When the player wins, show the number of guesses they made.

## Challenges
1. Stop players from entering invalid input (e.g. text or empty lines).
2. When the player doesn't give a `highest` or `lowest` value, use default values.
3. Add a leaderboard to the game. The leaderboard should keep track of the top 10 scores and display them at the end of the game.
