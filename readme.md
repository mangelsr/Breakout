# Breakout

A small **Breakout/Arkanoid-style** game prototype built with **Unity**.  
Control a paddle, bounce the ball, and clear all the bricks while experimenting with classic arcade mechanics.

---

## 🎮 Overview

**Breakout** is a learning / prototype project focused on recreating the core loop of the classic brick-breaker genre:

- Paddle that follows player input.
- Ball with basic physics / bouncing.
- Bricks with different hit points or behaviors.
- Simple game flow: start → play → win/lose.

The project is implemented as a standard Unity project, with gameplay logic in **C#** and visuals largely driven by **ShaderLab/HLSL** shaders.  

---

## ✨ Key Features

- **Paddle & ball gameplay**  
  Move the paddle horizontally to keep the ball in play and aim your shots.

- **Brick grid**  
  A wall of bricks to break; can be easily reconfigured to create new layouts.

- **Physics-based bouncing**  
  Ball reflects off the paddle, bricks, and walls using Unity’s physics.

- **Win/Lose conditions**  
  - Win: destroy all bricks.  
  - Lose: let the ball fall below the paddle too many times (or once, depending on the rules).

- **Extensible design**  
  Project structure makes it easy to add:
  - Multi-hit bricks
  - Power-ups (multi-ball, larger paddle, slower ball, etc.)
  - Score multipliers or combo systems

---

## 🧱 Project Structure

At a high level, the repository follows a typical Unity layout:​:contentReference[oaicite:1]{index=1}  

- `Assets/`  
  Main game content:
  - **Scenes** – Game scenes (e.g., main level, menu).
  - **Scripts** – C# scripts for paddle, ball, bricks, game manager, UI, etc.
  - **Prefabs** – Paddle, ball, brick, and other reusable game objects.
  - **Materials / Shaders** – Visual look of the game (ShaderLab/HLSL).:contentReference[oaicite:2]{index=2}  

- `Packages/`  
  Unity Package Manager configuration.

- `ProjectSettings/`  
  Unity project configuration (input, physics, graphics, etc.).

- `.vscode/`  
  Optional VS Code configuration for editing and debugging.:contentReference[oaicite:3]{index=3}  

- `.gitignore`  
  Git ignore rules for Unity.

---

## 🧰 Requirements

- **Unity** – Any recent Unity version compatible with the project (ideally an LTS version, e.g. 2021/2022 LTS).
- **Git** – (Optional) for cloning and version control.
- **C# IDE** – (Optional) e.g., VS Code, Rider, or Visual Studio.

---

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/mangelsr/Breakout.git
cd Breakout
