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


Resources used:
For Blender: 
https://www.youtube.com/watch?v=7VLqDctzvAk 

For Unity Animation Rigging set-up 
https://www.youtube.com/watch?v=Htl7ysv10Qs 

For math finding lerp, for rotating the player
https://www.youtube.com/watch?v=cOWHojRSGCU 

Besides that read through a lot of the unity documentation, like this: https://docs.unity3d.com/2022.3/Documentation/Manual/AnimatorWindow.html 

And tried every last one of the combinations, if I couldn’t figure it out. And read the ecompiled? of specific classes/methods/ect. in my IDE for answers.

For task times go look at the sent in report, can't figure out the formatting of this place, and it felt wrong to change it after deadline.  

