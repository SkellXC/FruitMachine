# FruitMachine

A slot machine game for Windows, built with C# Windows Forms. You start with 1,000 gold, place a bet on each spin, and win gold when two or three of the reels' symbols match.

## How to play

1. Enter a bet in the bet box. The game starts with 1,000 gold.
2. Press the spin button. The bet is taken from your gold and the three reels start spinning.
3. Press the stop button for each reel to stop it. Reels stop one at a time.
4. When all three reels have stopped, the game checks for a win and updates your gold.
5. Repeat until you run out of gold. The bet box is locked while reels are spinning.

Each reel shows a symbol in the middle position, with the symbols above and below it partly visible. The seven symbols are pearl, rainbow pearl, rainbow ball, slime, ruby, black prism, and passion fruit.

## Payouts

| Result | Gold returned | Net gain |
|--------|---------------|----------|
| All three reels match | 3 × bet | 2 × bet |
| Any two reels match | 1.5 × bet (rounded down) | 0.5 × bet |
| No match | 0 | Bet is lost |

## Known issues

- **Bet is not validated.** Non-numeric input causes an error, and bets larger than your gold are accepted, which can make your balance negative.
- **Two-reel matches can be missed.** The check for reels 1 and 2 does not wrap around the symbol list, so some matches involving the last symbol are not detected.
- **Misleading message.** Pressing spin while reels are still moving shows "You have no money left", even when you have gold.

## Requirements

- Windows
- .NET Framework 4.7.2 (set in `App.config`)
- Visual Studio with the ".NET desktop development" workload

2. Open `FruitMachine.sln` in Visual Studio.
3. Press **F5** (or **Debug > Start Debugging**) to build and run.

## Project structure

- `FruitMachine.sln`: Visual Studio solution file
- `FruitMachine/FruitMachine.csproj`: Project file
- `FruitMachine/Program.cs`: Entry point; starts `Form1`
- `FruitMachine/Form1.cs`: Game logic for spinning, stopping, bets, and payouts
- `FruitMachine/Form1_Designer.cs` and `Form1.resx`: Generated UI layout and resources for the main window
- `FruitMachine/Resource1.resx` and `Resource1_Designer.cs`: Symbol and background images
- `FruitMachine/App.config`: Runtime configuration
## Running the game

1. Clone the repository:
