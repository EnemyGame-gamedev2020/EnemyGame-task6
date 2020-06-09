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
- [HealthBarPlayer](https://github.com/EnemyGame-gamedev2020/EnemyGame-task6/blob/master/Assets/Scripts/HealthBarPlayer.cs) - Represents the Health of the enemy in the game.

Once the enemies feel danger (When the Health Bar drops to a certain number) they retreat to the dark to escape the player.


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

### Starting Position:
![image](https://user-images.githubusercontent.com/45036697/84187780-37244c80-aa9b-11ea-83fc-bf562eda7349.png)

### The player fights enemies:
![image](https://user-images.githubusercontent.com/45036697/84188192-dba68e80-aa9b-11ea-98cb-9c3981c42ca1.png)

### The player lost:
![image](https://user-images.githubusercontent.com/45036697/84188439-435cd980-aa9c-11ea-8281-953b7515c786.png)

### The player won:
![image](https://user-images.githubusercontent.com/45036697/84189482-009c0100-aa9e-11ea-9b0a-af1e4e8a2d3e.png)






