# 🚀 Space-Junkies Game 🎮

**A dynamic missile launch game built in VB.NET where players launch missiles by entering velocity and angle to hit enemy objects!**

## 📋 Project Overview

Missile Launch Game is a fun and engaging game developed using **VB.NET**. Players control a spaceship that launches missiles to hit enemy objects based on user inputs. The game offers two modes: **Normal** and **Hard**, each with increasing difficulty across multiple levels.

## 🎮 Game Concept

- Enter **velocity** and **angle** in the provided text boxes.
- Launch a missile to hit randomly placed or moving enemy objects.
- If the missile hits the target, the player earns points.
- The game progresses through **5 levels** in both **Normal** and **Hard** modes.
  - **Normal Mode**:
    - Static enemy objects placed at random positions.
  - **Hard Mode**:
    - Enemy objects move vertically (y-axis).
    - Increased difficulty with smaller enemies and faster movement.

## ✨ Features

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

## 🖥️ Installation Instructions

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/moin-ansari-o8/Space-Junkies.git
   ```

2. **Open in Visual Studio**:

   - Open the solution file `(.sln)` in Visual Studio.

3. **Build and Run**:

   - Build the solution and run the project using Visual Studio.

4. **Set Up Database**:

   - Make sure you have SQL Server or another compatible DBMS installed.
   - Import the database schema (for `userinfo` and `gameinfo` tables).

5. **Start Playing**:
   - Sign up or log in to start playing the game!

## Requirements

To run this game, ensure you have the following installed:

- **.NET Framework**: Version 4.5 or higher.
- **Visual Studio**: Any version that supports VB.NET development (Visual Studio 2010 or later recommended).
- **Database**: A local or remote SQL database to store user information and game data.

## Contributions

Contributions are welcome! If you would like to contribute to the development of this game, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Push to the branch.
5. Create a pull request with a clear description of your changes.

Your contributions will help enhance the game experience for all players!

## Contact Information

For any questions, feedback, or support regarding the game, feel free to reach out:

- **Name**: Moin Ansari
- **Email**: [moin.edu01@gmail.com](mailto:moin.edu01@gmail.com)
- **LinkedIn**: [https://www.linkedin.com/in/moin-ansari1817/](https://www.linkedin.com/in/moin-ansari1817/)

## Demo Video

Check out the demo video of the game to see it in action!

[Watch the Demo Video](something).

Enjoy playing the Missile Launch Game! 🚀
