# SnakeS
A Snake game that can be easily implemented on any .Net application 

# Installation :
Add the Block.cs, Blocks.cs, Settings.cs and Game.cs to your project.
Initialize the game by creating an instance of Game class :

> **Game** *game* = **new Game** ( *BlocksNumberOnX*, *BlocksNumberOnY*, *RefreshRateInMs*, *DisplayController* );

* BlocksNumberOnX   = Number of blocks on X axis
* BlocksNumberOnY   = Number of blocks on Y axis
* RefreshRateInMs   = Every how many ms do you want the game to refresh
* DisplayController = The controller on which the game will be displayed

# Public Methods
* Use the public methods **MoveUp()**, **MoveDown()**, **MoveLeft()** and **MoveRight()** to move the player
* Use the public method **Stop()** to stop the game and dispose all game controls at any time

Change Settings.cs to change the look of the game
