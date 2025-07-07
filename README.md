# Megabike

This is a Unity-developed video game which invites player to interact and have a complete conflict experience with LLM-powered agents.

## How to Use

In this repo is the Unity project files. Here's a quick guide on how you can open it in Unity, so that you can customize various parameters:

### 1. Download Unity
The Unity version I use is 6000.0.28f1. It's best to install the exact same version, but if you have a *slightly* different version, chances are that it will work equally fine anyway.

Once downloaded, open this project in Unity Hub.


### 2. Quick Overview
Before you go in and tune the parameters, here are the three main scenes:
- Lobby: The opening game menu, and player customization page.
- Main: the shared MegaBike riding experience.
- ChatRoom: you and other AI vote for each other.

You can find all those scenes under Assets/Scenes folder.

<img width="1277" alt="mb_tutorial_1" src="https://github.com/user-attachments/assets/f82e10ce-49cd-4260-957c-c5130d711f53" />
<img width="513" alt="image" src="https://github.com/user-attachments/assets/c6b1d790-9385-411e-98e0-4d820b3fd6d2" />

### 3. Parameters Tuning
There's a few easy parameters you can experiment with.

#### GPT config
Assets/Data/GPT config/GPT_Config

Select the GPT config file, and you should see the fields popping up in the inspector. Input your api key, or change the model as you like. All prompts can be changed.

#### AI Personality 
Assets/Data/Ai Personality/

You can see all the personality files here. Select one and you can adjust their name, appearance, personality prompt, and their movement parameters in game. Neglect the personality file for named Player, as changing it have no effect.

#### Who will vote player
This one is a little confusing -- the configuration is in the Scene. Double click on the "ChatRoom" Scene, in the hierarchy, go under ChatCanvas -> Voting Page -> ChattingRoom -> Characters, where you will see a list of characters. Click on any of them, and scroll down in the inspector, you will see their configurations. You can choose which position will 'definitely' vote for player.
<img width="1277" alt="image" src="https://github.com/user-attachments/assets/f42fda02-50ca-4d8a-8548-c2162d85f43d" />

#### When will Owdi Crash
The time which Owdi the monster will spawn in game is pre-scripted. Go to the main scene, then under Events -> Owdi Crash -> Scripted_OP_OwdiSpawner, you can adjust the delay where Owdi spawns.
<img width="1279" alt="image" src="https://github.com/user-attachments/assets/2c45ba54-88a5-4750-b6f4-7cdc0ceef1f3" />


### 4. Export to Application
Once finished, you can export the game to a .exe or Mac application, which should have plenty of tutorials online on how to do this.


Happy Mega-biking!

