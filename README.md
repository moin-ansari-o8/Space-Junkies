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

   - Open the solution file (".sln") in Visual Studio.

3. **Build and Run**:

   - Build the solution and run the project using Visual Studio.

4. **Set Up Database**:

   - Make sure you have SQL Server or another compatible DBMS installed.
   - Import the database schema (for `userinfo` and `gameinfo` tables).

5. **Start Playing**:
   - Sign up or log in to start playing the game!

## How to Play

1. **Start the Game**:

   - After launching the game, you will be presented with two modes: _Normal_ and _Hard_.
   - Select the desired mode to start playing.

2. **Input Values**:

   - Use the provided text boxes to input the missile's velocity and angle.
   - The missile will be launched based on these inputs.

3. **Objective**:

   - Your goal is to hit the enemy object using the missile.
   - In _Normal_ mode, the enemies are static but appear in random positions.
   - In _Hard_ mode, the enemies move vertically along the Y-axis, making it more challenging.

4. **Game Levels**:

   - There are 5 levels in both _Normal_ and _Hard_ modes.
   - As you progress through the levels, the difficulty increases (e.g., smaller enemies, fewer missile launch trials, faster enemy movement in Hard mode).

5. **Pause and Resume**:

   - You can pause the game at any time by clicking the **Pause** button.
   - A pop-up will appear with options to **Resume**, **Restart**, or **Exit** the game.

6. **Scoring**:

   - Points are awarded each time you successfully hit an enemy object.
   - Your progress is saved after each level.

7. **Settings**:

   - Customize the game interface through the **Settings** page, where you can change the background color, enemy object designs, and missile types.

8. **Leaderboard**:
   - The **Scoreboard** page shows the top scores from all players, highlighting your own score.
   - Scores are sorted to display the highest achievers at the top.

## Scoreboard Features

1. **View Player Scores**:

   - The **Scoreboard** page displays the scores of all players who have logged in to the game.
   - Your own score is highlighted for easy identification.

2. **Sorted Scores**:

   - Scores are automatically sorted in descending order, with the highest scores appearing at the top.

3. **Track Progress**:
   - The scoreboard allows you to keep track of your performance in comparison to other players.

---

## Game Progression

1. **Levels and Modes**:

   - The game has two modes: _Normal_ and _Hard_, each containing 5 levels.
   - In _Normal_ mode, the enemies are static and placed randomly on the screen.
   - In _Hard_ mode, enemies move vertically, increasing the difficulty as you progress.

2. **Difficulty Scaling**:

   - As you advance through the levels, the difficulty increases. This includes:
     - Decreased enemy object size.
     - Fewer missile launch trials.
     - Faster enemy movement in _Hard_ mode.

3. **Progress Saving**:
   - The game automatically saves your progress after completing each level, so you can resume later without losing your position.

---

## Customization

1. **Interface Settings**:

   - You can customize the game interface through the **Settings** page.
   - Options available include:
     - Changing the background color of the game.
     - Selecting different enemy object designs.
     - Customizing the appearance of the missile.

2. **User-Specific Preferences**:

   - The game saves your custom settings and loads them every time you log in, ensuring a personalized experience.

3. **Switch Accounts**:
   - The **Settings** page also allows you to switch between different user accounts or log out of the game.

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

[Watch the Demo Video](YOUR_VIDEO_LINK_HERE)

Replace `YOUR_VIDEO_LINK_HERE` with the actual URL of the demo video on platforms like YouTube.

Enjoy playing the Missile Launch Game! 🚀
