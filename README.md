# Project Name: E24YouSayRun  

**Name:** Emilie Høj Slente  
**Student Number:** 20223480  
**Link to Project:** [GitHub Repository](https://github.com/Slente468/PiVMiniProjectE24-EHS)  
**YouTube Demonstration:** [Game Demo](https://youtu.be/hY2Cs0Ti2vw) 
---
**Overview:** 
The idea/ inspiration behind this game is StarStableOnline, it’s basically an exploration quest game online with RPG on top. Where you explore the world and in quests one go from A to B completing an objective, to the best of one's ability, and you can sometimes do it faster by riding on your mount. The Goal of the game E24YouSayRun, is to obtain a quest and complete it, going from a to b, and then you get a timescore based on that. 

---

**The main parts of the game is:** 
 
player - human, moved with a combination of WASD.

terrain - open, but with constraints on where one can move easily. 

quest objective -  Animated golem floating some place. Getting close ends the run. 

audiosource - on all scenes can change what music you listen to, by pressing V.

horse - cannot be  ridden, but you can interact by pressing E on them if you are inside their collision to reset press Esc. 

---

**Parts of the course used in the game:** 

In general I made everything in the game. The player and the horse, and the golem, is made from scratch in Blender and rigged and transported into unity, where I did the animations to them. The player and horse both have a movement script to them that relies on rigidbodies. The Golem does have a particle system stuck to them, also the script it has gets triggered through collision. 
The part of the MountHorse() method that works, uses transforms to snap, the player to a position of a child on the horses. The terrain is built with terrain tools, the grass and tree, is both made in unity and has been distributed onto the terrain via terrain tools. 


**Project Parts:**
**·       Scripts Used:**
PM - player movement 

HorseMovement - makes it so Horse(horsetop) can function as a player and has MountHorse() method.

Highscore - tracks time in the Environment scene, does not actually give highscore. 

GollumManager - with collision trigger send player off to End scene. 

MusicScript - handles the music. 

ManagerOfScenesEntry - is used on buttons on the scenes: StartMenu, Settings, QuestSlide & End, to change scenes. 

Player Movement - not used, but does almost the same as the PM script

Reminder - just dictionary for comments 

DisplayHighScore - not used, has relation to Highscore script. 

Raycastings, not used,

**·       Models & Prefabs:**
- Golem, 
- horse, 
- player 
- stones 
3D models made in Blender by me. 
For the prefabs made them in unity

**·       Materials:**
- Basic Unity materials for all materials, outside of the blender models, which texture paints I made in blender. 

**The music used:**

- WaterSyntz, 2023
- AppEel.Rote, 2023
- E24, 2024
- peaceful morning, 2024
All the mini-pieces of music are made by me, and I therefore, as the composer, give myself permission to use them for this project. 
**·       Scenes:**
Game have 5 scenes: 
- StartMenu
- Settings
- QuestSlide 
- Environment
- End

**·       Testing:**
The game was tested on Windows, not built for other platforms. 
---



Note: The completion time of these tasks includes setting up the scenes, writing the scripts and research and testing of the code as I went along. Along with this whenever I started on a new task I start out with 30 minutes. where I code without tools outside of the unity manual as guidance. 

| **Task**                                  | **Time Spent in hourss**              |
|-------------------------------------------|-----------------------------|
| Setting up github and creating the unity project   | ⅚ hour                      |
| Paper prototyping/ finalizing idea of what to make.    | 8 hours                     |
| Making the PlayerManager script and basic movement using the WASD.              | 1 ⅚ hour                    |
| Adding a running mechanism to the PlayerManager script             | ⅓ hour                      |
| Adding a jumping mechanism to the PlayerManager script            | 1 ½ hour                    |
| Making the models in Blender of:
 2 rocks, a golem, the mount, and the player. 
This includes building them from scratch, rigging them and texture painting them.  and in this case redoing parts of the mount twice.Once because of the particle system, -had to redo textures as well. And the other time because of faces in the mesh missing when transporting  into unity.               | 16 hours                    |
| Research into the particle system in unity.    | 2 hours                     |
| Trying to get Github to work again                 | 5 hours                     |
| Research/brainstorming into getting mount to be mount        | 3 ⅔ hours                   |
| Making ManagerOfScenesEntry script and setting menus up in unity. | 4 hours                   |
| Art for StartScreen and Quest Slide ect. ,       | ⅓ hour                      |
| Setting the art into the menu scenes  + double checking everything      | 1 ⅙ hour                    |
| Doing the MusicScript               | 3 hours                     |
| Made HorseMovement script                     | ⅔ hour                      |
| Research into getting blender’s rigged model’s bones 2 show up in unity       | 3 hours                     |
| Made animations to mount, player model in unity  | 5 ⅚ hours                   |

| **Total (Game Implementation)**           | **69 ⅙ hours**              |

| **Total Development Time**                | **88 ⅓ hours**              |






 
Made DisplayHighScore script; 
⅔ of an hour

3  hours

5 hours and ⅚  
Made a ‘Quest slide’ scene, set up the same way as Startmenu and that and tried to get MusicScript to communicate with ManagerOfScenesEntry script. 
1 and ⅚ of an hour
Made ‘trees’ prefabs in unity 
⅔  of an hour
Setting up the state machines of the anime controllers
⅔ 
Adding animation bools in the Player movement script. 
1 ½  min. 
trying to get the player character to stop cartwheeling all over the place.
2
made terrain using terrain tools
2 ⅓  hours
added main camera to player and figured out how to upgrade the basic movement, so the camera rotates with the player when one walks in a direction. 
1 ⅓ 
Remade PlayManager Script as PM
⅓ of an hour
Made GollumManager script 
⅚ of an hour
Updated HorseMovement script
⅓ of an hour
bug fixing overall:  
9 and ½ of an  hour
Time spent on the stuff seen in the game:
69 and ⅙ of an hour
Research into stuff that I ultimately could not include into the game because of lack of time to figure it out / or half finished stuff..


Trying to get Mount Mechanic to work
3 and ⅓ of an hour
Highscore Script, and by extension DisplayHighScore
4 ⅙ of an hour
Blender particle system, to unity 
5 hours
RayCasting, there’s a script, but not used.
3 hours
Perlin noise generation 
1 
IK animations of mount and player model using Animation Rigging package
2 and ⅔  of an hour
Time spent in total on this project
88 ⅓ of an hour

Note; I had problems with github, so that’s why the project on Github is more or less one big commit, on the day instead of small ones through the whole period. 


Resources used:
For Blender: 
https://www.youtube.com/watch?v=7VLqDctzvAk 
For Unity Animation Rigging set-up 
https://www.youtube.com/watch?v=Htl7ysv10Qs 
For math finding lerp, for rotating the player
https://www.youtube.com/watch?v=cOWHojRSGCU 
Besides that read through a lot of the unity documentation, like this: https://docs.unity3d.com/2022.3/Documentation/Manual/AnimatorWindow.html 
And tried every last one of the combinations, if I couldn’t figure it out. And read the ecompiled? of specific classes/methods/ect. in my IDE for answers. 

