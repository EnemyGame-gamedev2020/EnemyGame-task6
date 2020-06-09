# Evil Enemy Game

The game takes place in a room. 

There are a number of enemies trying to eliminate the player. The player must hit the enemies and eliminate them before they will eliminating him.

**Created by:**

[Odelia Hochman](https://github.com/OdeliaHochman)

[Netanel Davidov](https://github.com/netanel208)


**Link to itch.io:**   [Evil Enemy Game](https://odeliamos0.itch.io/evil-enemy-game)


## Player  
The player has an option to move forward, backward, right, left. 

The moving is done using the arrow keys.

To fight enemies use the space key.

- `up key` - moves the player forward.
- `down key` - moves the player backward.
- `right key` - moves the player right.
- `left key` - moves the player left.
- `space key` - fight.


## Scripts

### Player:
- [Mover](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Scripts/Mover.cs) - Moving the player
- [HealthBarPlayer](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Scripts/HealthBarPlayer.cs) - Represents the Health of the player in the game
- [PlayerController](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Scripts/PlayerController.cs) - Represents player attacking and his damage status when injured by the enemies and his death.

 #### Fist:
 - [Fist](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Scripts/Fist.cs) - Represents the Fist of the player with it he hits the enemy


### Enemy:
- [Enemy](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Scripts/Enemy.cs) - Represents enemy situations in the game such as standing, walking, attacking and his damage status when injured by the player and his death.
- [EnemyClaws](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Scripts/EnemyClaws.cs) - Represents the claws with which the enemy fights


### Health Bar:
- [HealthBar](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Scripts/HealthBar.cs) - HealthBar colors 
- [Billboard](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Scripts/Billboard.cs) - Makes the object always parallel to the camera



### Target:
- [Target](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Scripts/Target.cs) - Represents the location the enemy will go to when his Health Bar will be in a certain number


## Animation:

- [stand](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Animations/Boody/stand.anim)
- [attack](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Animations/Boody/attack.anim)
- [die](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Animations/Boody/die.anim)
- [zombie attack](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Animations/Boody/zombie%20attack.anim)





## Images