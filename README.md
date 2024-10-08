# 🚀 Space-Junkies Game 🎮

**A dynamic missile launch game built in VB.NET where players launch missiles by entering velocity and angle to hit enemy objects!**

## 📋 Project Overview

Missile Launch Game is a fun and engaging game developed using **VB.NET**. Players control a spaceship that launches missiles to hit enemy objects based on user inputs. The game offers two modes: **Normal** and **Hard**, each with increasing difficulty across multiple levels.

## 🎮 Game Concept

- Enter **velocity** and **angle** in the provided text boxes.
- Launch a missile to hit randomly placed or moving enemy objects.
- If the missile hits the target, the player earns points.
- The game progresses through **5 levels** in both **Normal** and **Hard** modes.

## 🕹️ Game Modes

1. **Normal Mode**:
   - Static enemy objects placed at random positions.
2. **Hard Mode**:
   - Enemy objects move vertically (y-axis).
   - Increased difficulty with smaller enemies and faster movement.

## ✨ Features

- Two engaging modes: **Normal** and **Hard**.
- Missile trials are limited, and difficulty increases with progression.
- Customizable game interface (background color, enemy objects, and missile types).
- **Pause button** with options to **Resume**, **Restart**, or **Exit** the game.
- Scoreboard to track and highlight player scores.

## 🗂️ Project Structure

- **Sign Up/Sign In**: User authentication with a "Remember Me" feature.
- **Menu**: Main menu with options like Play, Scoreboard, Levels, Help, and Settings.
- **Game Interface**: Input velocity and angle to launch missiles.
- **Scoreboard**: Displays all players' scores, highlighting the logged-in player's score.
- **Levels**: Select Normal or Hard mode, each with 5 levels.
- **Help**: Information about the game objects and their functions.
- **Settings**: Allows players to log out, switch accounts, or modify game interface settings.

## 🛠️ Technology Stack

- **Front-end**: VB.NET (Windows Forms)
- **Back-end**: VB.NET
- **Database**:
  - **userinfo** table: Stores username, email, and password.
  - **gameinfo** table: Stores game mode, level progress, and game settings for each user.

## 💾 Database Details

1. **UserInfo**: Stores user credentials (username, email, and password).
2. **GameInfo**: Tracks current game mode, cleared levels, and user-specific settings.

## 🖥️ Installation Instructions

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/missile-launch-game.git
   ```
2. **Open in Visual Studio**:

- Open the solution file (.sln) in Visual Studio.
