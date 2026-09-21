# Unity Game Development Summary

| Field | Detail |
|---|---|
| **Game Title** |Knight Knock |
| **Student Name(s)** |Tommy Dockrill, Daichi Mura |
| **Class / Course** |Computer Technology |
| **Repository** |2026CT_GameDesign_Ninja_Tommy.D |
| **Unity Version** |6000.0.58f1
| **Document Version** |0.1|
| **Date** |27/8/26

---

## Table of Contents
1. [Game Overview](#1-game-overview)
2. [Video Walkthrough](#2-video-walkthrough)
3. [Game Mechanics](#3-game-mechanics)
4. [Visual Features](#4-visual-features)
5. [Audio Design](#5-audio-design)
6. [User Interface & HUD](#6-user-interface--hud)
7. [Scene & Level Design](#7-scene--level-design)
8. [Scripts & Programming](#8-scripts--programming)
9. [Development Techniques & Tutorials Acknowledged](#9-development-techniques--tutorials-acknowledged)
10. [Third-Party Content Acknowledgements](#10-third-party-content-acknowledgements)
11. [Challenges & Solutions](#11-challenges--solutions)
12. [Branch Development Summary](#12-branch-development-summary)

---

## 1. Game Overview
My game is a fun platformer game where you play as a Knight jumping from platfor to platform with various movement mechanics, killing any enemies you see along the way. My game has a pixelated art theme where you play as a medieval knight fighting futuristic enemies. You play in a forest That has an eary theme to it with weird blue shurb and forest in the distance. The players weapon of choice is the sword. It fits the game well leaving the player with something not too overpowered without feeling weak.

### 1.1 Genre
My game is part of the platform genre. Since it is made in a 2d game engine you dont have to account for the extra axis of movement when making the game. This genre is known for its user friendly mechanics and ease of play due to its simple nature of having 2 movement axises. 

### 1.2 Target Audience
My target audience is very large since my game isnt mature and doesnt feature any explicet content is child friendly.
This means any age from 5 to 70 could play my game and even beyond that  and before if they posses video game skills, However the theme of my game being a platformer means it would appeal to gamers who enjoy games of this catagory. My platformer features basic moves which can be found in a lot so people with past expierence in this genre wont have difficulty picking up my mechanics.

### 1.3 Game Summary


### 1.4 Win / Loss Conditions
Loss | players can die to spikes or enemies
win | switching levels to kill enemies and experience game mechanics

### 1.5 Platform & Build Settings
| Setting | Detail |
|---|---|
| Target Platform | |
| Resolution | |
| Build Type | |

---

## 2. Video Walkthrough

### 2.1 Full Gameplay Walkthrough

<!--
  Embed a YouTube/Vimeo video or link to a file in the repository.
  YouTube embed syntax:
  [![Video Title](https://img.youtube.com/vi/VIDEO_ID/0.jpg)](https://www.youtube.com/watch?v=VIDEO_ID)

  OR link to a local file:
  [Watch Walkthrough Video](./docs/video/walkthrough.mp4)
-->

| Field | Detail |
|---|---|
| **Video Title** | |
| **Link / Embed** | |
| **Duration** | |
| **Description** | |

### 2.2 Feature Highlight Clips

| Clip | Description | Link |
|---|---|---|
| | | |
| | | |
| | | |

---

## 3. Game Mechanics

### 3.1 Core Mechanics
| ID | Mechanic | Description | Implemented In (Script/Object) |
|---|---|---|---|
| M-1: Player movement
My player movement features a a wide range of ways to navigae levels. I have standard A.D movement with a jump on space. I also have a dash on shift. My player can also wall slide by letting go of the spacebar on a wall and then can get a second jump when it is in contact with a wall which is called a "wall jump."

| M-2: Enemy
I have 1 type of enemy in my game which features a dmg variable, has health and i can ajust both of these values in the unity interface. My enemy also features point A,B path finding where it will patrol between two specific points until the player gets within its vercinity which i can ajust with a value in unity.

| M-3: Parallax Background
My game features a infinite scroll parallax background which  never ends. It features 5 layers where they all move at their own individual speed which i can just in the unity hireachy. This gives emmersion and a sense of progression when the player is always seeing the background move.

| M-4:Sword and Damge
The player has a sword which is the weapon he uses to kill enemies. Its hitboxis slightly offset so it reaches out far enough to hit enemies. Its damage  is adjustable and so is the enemies health and damage it deals. The sword has an animation and hitbox so it can move and function normally like it would in any other game.

| M-5: Spike
i have added spikes as an obstacle which deals damage through the damage variable and has a customizeable damage integer. The spikes can be copied to place them anywhere in the level and can be stacked in a line to be a bigger obstacle. They feature a sprite which then has a hibox lining up with the top of the sprite allowing for no areas where damange can be taken without visable contact with the spike. 

### 3.2 Player Controls
| Action | Input (Keyboard / Controller) | Description |
A,D: Which is my left right movement so the player can move
Shift: This key allows my player to dash which is a fast boost of movement which launches the player forward
Space: This is my jump, wall slide and walljump key all in one which makes sense since all functions are related to jumping.
left MB Click: This is my player sword attack button which allows my player to hit the enemy and deal dmg.
1 button | this lets the player swap scenes to the next level.


### 3.3 Physics & Collision
| Feature | Description |
Wall Jump | Jump or hang or slide off walls|
spikes| contact or stand on top of them to take damage
gavity| takes player back down when jump\fall

### 3.4 Game Loop
| Stage | Description |
|---|---|
| Start / Initialisation | |
| Core Loop | |
| Win / End State | |
| Restart | |



---

## 4. Visual Features
Parallax background | creates depth effect for background

### 4.1 Particle Effects

| Effect Name | Purpose | Screenshot |
|Trail Renderer|The trial behind player when dash|---|


> Add screenshot images using: `![Effect Name](./docs/screenshots/effect_name.png)`

---


> Add screenshot images using: `![Cut Scene Name](./docs/screenshots/cutscene_name.png)`

---

### 4.3 Animations

| Animation | Object / Character | Description | Screenshot |
Jump Anim | Player | shows the player visually jumping |
Run anim | player | shows the player running| 
idle anim | The players small movements when idle |
Sword anim | The animation that players when the player attacks with the sowrd| 
health anim| Hud | When the health of player goes down the health bar displays that|
transition anim | fades from scene 1 to two when player presses 1 wanting to switch levels|



> Add screenshot images using: `![Animation Name](./docs/screenshots/animation_name.png)`

---

### 4.4 Lighting & Post-Processing

None

> Add screenshot images using: `![Feature Name](./docs/screenshots/lighting_name.png)`

---



> Add screenshot images using: `![Shader Name](./docs/screenshots/shader_name.png)`

---

### 4.6 Additional Visual Screenshots

<!--
  Add any other notable screenshots here.
  Syntax: ![Description](./docs/screenshots/filename.png)
-->

| Description | Screenshot |
|---|---|
| | |
| | |
| | |

---



### 5.1 Music
| Track | Scene / Trigger | Source / Composer |
|Moonspire|Every scene|Unity Sset store:alkakrab| used as background music for entire game




### 6.1 HUD Elements
| Element | Purpose | Screenshot |
| Control hud| displayes the controls for the player to see which appear on the left of the scren
| healthbar element | shows the health of the player |
| Scene transition element | a hud element which tells the playerby pressing button 1 they move to a different level


> Add screenshot images using: `![HUD Element](./docs/screenshots/hud_name.png)`

### 6.2 Menus
| Menu | Purpose | Screenshot |
Main menu hud | featured in the first scene where the player starts gives the options to play the game and start or to exit the game fully. Features game name and light up highlighting start and exit buttons with coresponding colours
| Pause Menu | | |


> Add screenshot images using: `![Menu Name](./docs/screenshots/menu_name.png)`

---

## 7. Scene & Level Design

### 7.1 Scene List
| Scene Name | Purpose | Description |
StartScene | is the menu scene for the game | Allows for the player to start or exit the game and means they dont have to jump straight into the action
Scene1 | level 1 | is the first level of the game |
scene2 | level 2 | is the second level of the game

### 7.2 Level / Environment Screenshots
| Level / Area | Description | Screenshot |
Level 1 | forest | A good entry level to introduce mechanics allowing for players to get used to mechanics |
level 2 | forest | A harder version of level 1 which is more challenging requiring more effort and skills


> Add screenshot images using: `![Level Name](./docs/screenshots/level_name.png)`

### 7.3 Scene Management
| Feature | Description |
Main Menu | allows to exit the game and start and get sent to level 1
Scene transition | my transition from level 1 to 2 is done by the player prssing Button 1 which is signaled by the hud which gives them the freedom to move from level to level
| Scene Loading Method |Menu Button and keyboard button which allows for full freddom of game |
| Scene Transition Effects |Fade in and out which is animated |

---

## 8. Scripts & Programming

### 8.1 Script Summary
| Script Name | Attached To | Responsibility |
|---|---|---|
| | | |
| | | |
| | | |
| | | |
| | | |

### 8.2 Key Algorithms / Logic
| Feature | Script | Description |
|---|---|---|
| | | |
| | | |
| | | |

### 8.3 Design Patterns Used
| Pattern | Where Applied | Justification |
|---|---|---|
| | | |
| | | |
| | | |

---

## 9. Development Techniques & Tutorials Acknowledged

> List every tutorial, course, video, or article that informed or guided your implementation. Include what you used it for and what you changed or adapted.

| # | Title | Author / Creator | URL / Source | What You Used It For | What You Changed / Adapted |
|---|---|---|---|---|---|
| 1 | | | | | |
| 2 | | | | | |
| 3 | | | | | |
| 4 | | | | | |
| 5 | | | | | |
| 6 | | | | | |
| 7 | | | | | |
| 8 | | | | | |

---

## 10. Third-Party Content Acknowledgements

Hero Knight - Pixel Art by sven Thole: https://assetstore.unity.com/packages/2d/characters/hero-knight-pixel-art-165188

### 10.1 Visual Assets
Enemy galore pack by Admurin: https://assetstore.unity.com/packages/2d/characters/enemy-galore-1-pixel-art-208921
Greek/Fanatasy Enemies by Potion junkies:https://assetstore.unity.com/packages/2d/characters/greek-fantasy-enemies-204779
Animated Text Reveal by BitWave Labs: https://assetstore.unity.com/packages/2d/gui/animated-text-reveal-314861
Pixel Art Woods Tileset and Backgrounds by Karsiorihttps://assetstore.unity.com/packages/2d/environments/pixel-art-woods-tileset-and-background-280066
Hero Knight - Pixel Art by sven Thole: https://assetstore.unity.com/packages/2d/characters/hero-knight-pixel-art-165188
2d Platform Tile Set - cave by Iphigenia pixels: https://assetstore.unity.com/packages/2d/environments/2d-platfrom-tile-set-cave-61672
Free Pixel Art Kit By PolyMesh World :https://assetstore.unity.com/packages/2d/environments/free-pixel-art-kit-211149
Free 2d cartoon parallax Background by CPasteGame: https://assetstore.unity.com/packages/p/free-2d-cartoon-parallax-background-205812
pixel Art Platformer Village props by Cainos:https://assetstore.unity.com/packages/2d/environments/pixel-art-platformer-village-props-166114

### 10.2 Audio Assets
| Moonspire | Background music | alkakrab | [Licence](https://unity.com/legal/as-terms) | [URL](https://assetstore.unity.com/packages/audio/music/free-10-medieval-ambient-fantasy-tracks-music-pack-310781) | used for the background music in my game fitting the games theme |


### 10.3 Scripts & Code Snippets
| Script / Snippet | Source | Licence | URL | Used For | Changes Made |
|---|---|---|---|---|---|
| | | | | | |
| | | | | | |

### 10.4 Unity Packages & Plugins
| Package Name | Version | Source | Licence | URL | Purpose |
|---|---|---|---|---|---|
| | | | | | |
| | | | | | |
| | | | | | |

### 10.5 Fonts
none

---

## 11. Challenges & Solutions

| # | Challenge Encountered | How It Was Solved |
Parallax background | I had several issues when coding my paralax backgroumd. It constantly wouldnt work with error messages poping up, the backgrounds moving too fast and texture bugs. It ended up taking me 4 lessons to complete my parallax background. The main issue i encountered was i was trying to do a looping parallax rather then an infinite one. I wasnt aware but an infinite parallax is much better suited for my poject so after i encountered too many issues with the looping parallax i switched styles and the debuging process not only was easier with the infinite parallax but it looks much better as well.

Animation Controller | I had several issues with my animation controller, but the main one being since my multi teammate gave me sprites which werent the same size. This small minute detail in the controller being that sprites arent the same size and ratio ment the controller wouldnt animate at all. I went through the whole debug process of debuing the animator but only after i had tried everything did i realise the sprites were a different size. So i substituted in a sprite and animation from the unity asset store and the controller immediatley worked meaning that all i needed to change was a sprite after all.

---

## 12. Branch Development Summary

> One section per feature branch. Add or remove sections to match your repository. Branches should be named for the feature they implement e.g. `feature/player-movement`. Link each branch name directly to the branch in your GitHub repository.

---

### Branch 1 — `main`

| Field | Detail |
|---|---|
| **Branch Name** | `main` |
| **Purpose** | Stable, releasable version of the game |
| **Merged From** | |
| **Final Commit** | |

---

### Branch 2 — `feature/`

| Field | Detail |
|---|---|
| **Branch Name** | |
| **Feature Developed** | |
| **Merged Into** | |
| **Date Started** | |
| **Date Merged** | |

#### What Was Built
<!-- Describe what this branch added or changed -->

#### Key Commits
| Commit Message | What Changed |
|---|---|
| | |
| | |
| | |

#### Problems Encountered & Resolved
| Problem | Resolution |
|---|---|
| | |
| | |

#### Screenshot / Evidence
<!-- Add a screenshot of the feature working -->
> `![Feature Name](./docs/screenshots/branch_feature_name.png)`

---

### Branch 3 — `feature/`

| Field | Detail |
|---|---|
| **Branch Name** | |
| **Feature Developed** | |
| **Merged Into** | |
| **Date Started** | |
| **Date Merged** | |

#### What Was Built


#### Key Commits
| Commit Message | What Changed |
|---|---|
| | |
| | |
| | |

#### Problems Encountered & Resolved
| Problem | Resolution |
|---|---|
| | |
| | |

#### Screenshot / Evidence
> `![Feature Name](./docs/screenshots/branch_feature_name.png)`

---

### Branch 4 — `feature/`

| Field | Detail |
|---|---|
| **Branch Name** | |
| **Feature Developed** | |
| **Merged Into** | |
| **Date Started** | |
| **Date Merged** | |

#### What Was Built


#### Key Commits
| Commit Message | What Changed |
|---|---|
| | |
| | |
| | |

#### Problems Encountered & Resolved
| Problem | Resolution |
|---|---|
| | |
| | |

#### Screenshot / Evidence
> `![Feature Name](./docs/screenshots/branch_feature_name.png)`

---

### Branch 5 — `feature/`

| Field | Detail |
|---|---|
| **Branch Name** | |
| **Feature Developed** | |
| **Merged Into** | |
| **Date Started** | |
| **Date Merged** | |

#### What Was Built


#### Key Commits
| Commit Message | What Changed |
|---|---|
| | |
| | |
| | |

#### Problems Encountered & Resolved
| Problem | Resolution |
|---|---|
| | |
| | |

#### Screenshot / Evidence
> `![Feature Name](./docs/screenshots/branch_feature_name.png)`

---

### Branch 6 — `feature/`

| Field | Detail |
|---|---|
| **Branch Name** | |
| **Feature Developed** | |
| **Merged Into** | |
| **Date Started** | |
| **Date Merged** | |

#### What Was Built


#### Key Commits
| Commit Message | What Changed |
|---|---|
| | |
| | |
| | |

#### Problems Encountered & Resolved
| Problem | Resolution |
|---|---|
| | |
| | |

#### Screenshot / Evidence
> `![Feature Name](./docs/screenshots/branch_feature_name.png)`

---

### Branch Development Overview

> Complete this summary table once all branches are finished.

| Branch Name | Feature | Date Started | Date Merged | Status |
|---|---|---|---|---|
| `main` | Stable release | | | |
| `feature/` | | | | |
| `feature/` | | | | |
| `feature/` | | | | |
| `feature/` | | | | |
| `feature/` | | | | |

---

> **Student Declaration:** All work submitted is my own except where explicitly acknowledged above.