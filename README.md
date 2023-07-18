# AI Ascendancy

Game Design Document


# Introduction

This document specifies a design for the gameplay of a game with the provisional title "AI Ascendancy". It is based on various strategy games that implement swarm control and capture.

# Target Systems

The following systems will be targeted for deployment: Windows 10 & 11, Linux, MacOS.

# Development System

The development system to be used is the MonoGame framework. Specifically the template called DesktopGL. DesktopGL uses SDL for windowing, OpenGL for graphics, and OpenAL-Soft for audio. The C# programming language will be used within the Visual Studio Code Editor.

# Specification

## Concept

The aim of AI Ascendancy is to produce a fun and addictive swarm-based strategy game.

## Story

### Setting

The game will be set in the far future where the player takes control of an AI with the intent of Ascendancy.

## Game Structure

The game will take place in a large galaxy with individual systems(levels). Upon completion of a level the player will unlock the next level. In between levels the player will have access to the upgrade facility within the Alpha ship

## Players

The game is intended to be single player to ensure simplicity. Although, it is possible that online play will be added in the future allowing players to fight for ascendancy.

## Action

Players will control large ships known as replicators. The replicators produce small drones at a consistent rate until a specified capacity is reached. The player can direct the movement of the replicator ships as well as the swarm of drones. The main focus is strategy through timing and movement.

## Objective

The objective of the game is to clear all levels. Clearing a level requires that all enemies be destroyed or captured. The Player can direct the drones to move towards enemies. The drones will automatically attack the enemies. The drones can also be directed towards the replicator ships, upgrading them to have a stronger hull and a higher replication rate. Upon elimination of an enemy, the player can direct the drones to capture the now derelict enemy ship, effectively adding to the players fleet.

## Upgrade Screen

On this screen the player can use upgrades gathered from the battlefield to upgrade the drones and replicator ships. Upgrades can be joined together to acquire more powerful upgrades. The requirements are three of the same upgrade and level to reach a more powerful version.

# Graphics

## Background

The background will be viewed as if above the ships. Initially, the backgrounds will be hand-made, but eventually they will be procedurally generated to make the development load lighter. There will be a few animated objects in the background such as comets, asteroids, and derelict ships.

## Objects

Objects will be drawn using some scaled & rotated sprites. Each will be around 64x64 pixels. All objects will be viewed from above. There will be three states (art) for the replication ships: level 1, level 2, level 3. Drones will always look the same and therefore use the same sprite. Objects that float in the background will have enough variation (10?) so as to not attract unwanted attention.

## Screen Display

A time acceleration button will be available with a display to indicate the current time rate. Increasing and decreasing the time speed will be assigned to hotkeys. A menu icon will be displayed in the top left corner allowing access to restart, options, continue, and exit.

# Data Storage

## Replicator Ship Sprites

Replicator ships will be symmetrical in both the x and y axis. This means storing only 1 frame per ship upgrade level. The rotation of the ships will be done in the software. Deltas will be drawn onto the ships to add detail, such as the amount of hull left, and the progress towards the next level.

## Level Backgrounds

The level backgrounds will initially exist as pre-made images(png) that will be loaded into memory on level initialization. Additional sprites for floating objects will already be loaded into memory on game initialization as there will be a known set amount that is unlikely to change.

## Sound

Sound will be stored in mp3 files? The soundscape will be as simple as possible, while also providing the player a small amount of satisfaction. Menu buttons will have a sound on when hovered and pressed. In the game, there will be ambient background sound. Following is a list of known sounds:

- Ship destruction
- Ship upgrade
- Ship capture
- Selection
- Movement order
- Drone destruction
- Drone upgrading

# Gameplay

## World

The playing world will initially be quite small and contain only 10 levels. Each level will vary in size and orientation.

## Spacescape

The spacescape will consist of:

- Stars
- Planets
- Asteroids
- Comets
- Derelict spaceships

The spacescape is not fixed and will constantly be in motion. The stars, planets, and the majority of the asteroids will be stationary. Some asteroids, the comets, and the derelict spaceships will be in motion.

The stars, planets, comets, and most asteroids will be in the distance. Meaning the ships will be able to move over them, there will be no collision. Asteroids, derelict ships, and active ships will all have collisions.

## Object Types

Objects that can appear include:

- Active Ships
- Drones
- Derelict Ships
- Asteroids

## Control

The game will be controlled by mouse and keyboard.

The controls are as follows:

- Drag to select (LMB)
- Order Movement (RMB)
- Zoom in (Scroll Wheel)
- Pan (MMB)
- Pan Left (A)
- Pan Right (D)
- Pan Up (W)
- Pan Down (S)
- Time Accelerate (E)
- Time Decelerate (Q)

# Front End

## Intro

A simple splash screen will be displayed and will transition to the main menu upon completion of initialization.

## Menus

A simple main menu that will have the following options:

- Campaign
- Upgrades
- Settings
- Quit

The settings menu will have the following options:

- Music level
- Sound level
- Difficulty
- Localization?

# Development Tools

VS Code, MonoGame, MonoGame Content Builder (MGCB), MonoGame Effects Compiler (MGFXC).

# Team

Project Manager, Programmer, Art, Design, Producer: Zachary Pruessner