This simulates a game of darts where players can sabotage each other to lower their chance of hitting the target. Player 1 sabotages, then player 2, then player 3. After that, each player’s chance of hitting the target is simulated. The first to 5 hits wins.


Player 1 starts with a 25% chance of hitting the target. They can sabotage another player to lower their chance by 6%
Player 2 starts with a 35% chance of hitting the target. They can sabotage player 1, or player 2 for 8%, or both players for 4%.
Player 3 starts with a 30% chance of hitting the target. They only sabotage players who sabotage them, for 10%.


Player 1 goes (the user inputs 2 or 3 for who they want to attack), then player 2(decided by rng), then player 3(automatically calculated). 


The way hitchance is calculated is by subtracting the players hit chance from a  random number, from 1 to 100(inclusive). If the remainder is 0 or less, they hit, otherwise they miss. 
Say a player had a 25% chance of hitting a target. If the random number is between 0 and 25, they hit, if it's between 26 and 100, they miss. This simulates random chance. 


After each player's choice is decided, who they are targeting and their new chance of hitting is displayed, along with the current round. The user input is for player 1, either the 2 or 3 key, and then the spacebar to play the round.


Since all of the logic is contained in the update method, there is no way to put in variables to unit test the method. Player 1 can be tested via its input, player 2 is random, and player 3 is automatic. Therefore it would be impossible to implement unit testing without breaking down the code, which would just make it more complicated. I set up scripts to have the unit tests in to show I know how to make them, but they were incompatible with my project.