# Plants vs Zombie Inspired Game (C# OOP)

A Windows Forms tower-defense style shooter game inspired by *Plants vs Zombies*.  
Developed in C# using object-oriented programming principles.

---

## Features
- Player controls a plant that remains fixed in its column but can move vertically within its lane
- The plant protects the house by firing lasers at approaching zombies
- If a zombie passes through the lane and reaches the house, the player's health decreases
- Enemy spawning with randomized rows
- Collision detection between lasers and zombies
- Health system with progress bar
- Score tracking and win/lose conditions
- Sun power-up for health restoration

---

## Object-Oriented Programming Concepts
- **Encapsulation**: Classes for player, enemies, and lasers
- **Inheritance**: Abstract `Lazer` base class → `lazerBlue` derived class
- **Polymorphism**: Overridden methods for projectile behavior
- **Abstraction**: Simplified game loop and UI interactions

---

## Controls
- **Arrow Up/Down**: Move plant within the lane  
- **Spacebar**: Shoot laser  
- **R**: Restart after game over  

---

## Gameplay Screenshots

![Screenshot1](docs/Screenshot1.png)
![Screenshot2](docs/Screenshot2.png)
![Screenshot3](docs/Screenshot3.png)
![Screenshot4](docs/Screenshot4.png)
![Screenshot5](docs/Screenshot5.png)


---

## Future Improvements
- Multiple plant types with unique shooting patterns
- Different enemy types with varying speed and health
- Levels/waves with increasing difficulty
- Sound effects and background music
- High-score tracking and persistence

---

## Summary
This project demonstrates the use of C# OOP to build a basic but engaging tower-defense game with Windows Forms.  
The plant moves vertically within its lane to defend the house, while zombies attempt to break through.  
Through class inheritance, encapsulation of logic, and dynamic UI control, it showcases foundational skills in game development and desktop application programming.
