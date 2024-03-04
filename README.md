# Chess_game
♟️ A chess game project on C#

### How will the game look
The game will consist of a board where all the pieces are represented. At it's turn the user will be able to select a piece by clicking on it, and little dots will appear on the board, showing it where the piece is allowed to move (it is supposed to look like the interface of [Chess.com](https://www.chess.com/home)). A timer will be on the side of the board. The user would be able to select the time of each player. All the "special rules", such as _en passant_ or _pawn promotion_ would be working.

### How I am planning to make it works
The code will be separated in 4 parts:
- The graphic interface, representing the board with all the pieces at any time and allowing the user to select a piece and to select where it wants to move it
- A class with all the information about a single piece: it's Id, it's color, wether it was eaten or not, where it can moves (using vectors), ...
- A timer, constantly updating
- And finally a main programm, making everything work at once
