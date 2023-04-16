# ClassicArcadeGame

Summary:
The Reign of the Barrel Dragon is a Unity-based game that pays homage to classic arcade games in a modern 3D space, with a twist on the iconic Donkey Kong gameplay. Developed from scratch using Unity and C#, this game features immersive gameplay, challenging obstacles, and a visually appealing retro arcade aesthetic.

Players will embark on an exciting adventure as they control the game's protagonist, navigating through two levels filled with obstacles and enemies. The goal is to reach the top of each level and pass through the shiny door to win. However, players must collect enough coins to achieve a target score before they are allowed to pass through the door and advance to the next level.

The game features smooth controls, dynamic camera angles, and captivating level designs that increase in difficulty as players progress. Players must overcome various challenges, including avoiding rolling barrels, navigating platforms and ladders, and timing their movements strategically to reach the top. As an unexpected twist, there is a hidden element that can attack the player when least expected, adding an element of surprise and challenge.

With its modern 3D gameplay and retro arcade aesthetics, The Reign of the Barrel Dragon offers a unique take on the classic arcade experience. Whether you are a fan of Donkey Kong or enjoy challenging platformer games, this Unity-powered game promises hours of thrilling and strategic gameplay as players strive to reach the top and pass through the shiny door to victory.

Steps for Creating The Reign of the Barrel Dragon Game:

Story 1:

* Created four scenes using Unity: The main Menu, the game, the Winning Menu, and the Game Over Menu.
* Implemented a C# script to load each scene, allowing seamless transitions between scenes.

Story 2:

* Designed the game prototype, including elements such as ladders, player character, enemy character, enemy weapon, ground, and finish line.
* Developed C# code to enable player movement in the 3D space, including jumping and climbing ladders, although some stability issues were encountered.
* Implemented a camera system to follow the player character during gameplay.

Story 3:

* Modified the game dynamics by changing the behavior of barrels, which now fall forward from the center and highest point in the level.
* Added spawn shooters to shoot the barrels, and successfully implemented the functionality.
* Added various game mechanics, such as randomization of falling barrels, player losing life upon colliding with barrels, triggers around the edges of the world to destroy remaining barrels and end the game if the player falls, and a winning trigger to go to the win menu.
* Implemented collision detection between barrels, barrels vs. player, and developed a new enemy in the form of a hammer that shoots out of a trigger when the player least expects it.

Story 4:

* Added coins as collectible items in the game, along with a new way to shoot barrels and awarded points for each collected coin.
* Implemented background music for each scene, as well as sound effects for collecting coins, barrels' movement, and hammer attack.
* Added sound effects for player jumping and getting hit.

Story 5:

* Added 3D models of shapes with textures to create materials for the game world, including the floor of each level, ladders, a cannon to shoot barrels, and coins.
* Implemented lighting, particles, UI elements, and 3D models of enemy and player characters to enhance the visual aesthetics of the game.
* Added functions and animations to the player character to enable smooth movement.
* Added a light object as the final trigger for player winning the game and fixed ladder mechanics for smoother climbing. Considered changing the game's title, as it has evolved from its original inspiration of Donkey Kong.

Story 6:

* Added functionality to display the final score in the win and game over menus.
* Added a second level to the game and enabled the player to go back to the Classic Arcade Menu from the DK_game menu.
* Implemented a requirement for the player to collect a certain number of coins to progress to the next level.

Throughout the development process, various challenges were encountered and overcome, such as stability issues with player movement, implementing complex game mechanics such as barrel falling behavior and hidden enemy attacks, and integrating 3D models, animations, and audio elements to enhance the overall gaming experience. The Reign of the Barrel Dragon is a unique and engaging Unity-based game that provides players with challenging gameplay, immersive 3D visuals, and a captivating arcade-style experience.
