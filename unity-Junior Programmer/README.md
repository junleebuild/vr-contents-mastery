## 📆 2025-07-03: Started Junior Programmer Curriculum - Day 1

### 🎮 New Functionality Implemented

- Imported Unity project with required assets
- Positioned vehicle at start of road
- Placed obstacle in front of the vehicle
- Positioned camera behind the vehicle
- Vehicle moves forward automatically
- Obstacles react with physics when hit by vehicle
- Camera follows the vehicle at a set offset
- Player can now control the vehicle:
  - Up/Down arrows to move forward/backward
  - Left/Right arrows to turn

### 🧠 New Concepts & Skills Learned

- Project setup and asset importing
- 3D Scene navigation, layout customization
- Understanding Game View vs Scene View
- Unity Editor windows: Project, Hierarchy, Inspector
- Move/Rotate tools
- C# scripting basics:
  - `Start()` vs `Update()`
  - Comments and Methods
  - Parameters, `Time.deltaTime`, `*` operator
  - Using components: `Collider`, `Rigidbody`
- Variables and data types
- Access modifiers (`public`, `private`)
- User input with `Input.GetAxis`
- Translate vs Rotate in code
- Created and used empty GameObjects

### ✅ Challenge Completed

- Fixed the airplane control bug in Challenge 1

### 🔜 Next Plan

- Complete remaining parts of **Chapter 1: Player Control**
- Take the corresponding quiz

## 📆 2025-07-05: Junior Programmer - Chapter 1 Complete

### 🎮 New Progress

- Completed the second half of **Chapter 1: Player Control**
- Finished the quiz for Chapter 1
- Defined and documented a **personal project concept**
- Established a **production timeline** for the project

### 🧠 New Concepts & Skills Learned

- Writing and organizing **Design Documents**
- Creating a **Project Timeline** with milestones
- Structuring a **Backlog** for development tasks
- Understanding and planning **Minimum Viable Products (MVPs)**

## 📆 2025-07-06: Junior Programmer - Chapter 2 Progress

### 🎮 New Functionality

- Player can **move left and right** based on user input (`Left` / `Right` arrow keys)
- Player **cannot exit** the play area boundaries
- Player can **press Spacebar to launch projectiles**
- **Projectiles** and **animals** are **destroyed** when they leave the screen

### 🧠 New Concepts & Skills Learned

- Adjusting **object scale**
- Using **if-statements** and **else-if statements**
- Applying **greater-than / less-than** comparison operators
- Creating and **instantiating prefabs**
- **Overriding prefab** values
- Detecting **key presses**
- Using `Instantiate()` to spawn objects
- Using `Destroy()` to remove objects from the scene

### 🔜 Next Lesson Preview

- Create and launch **endless food** to feed animals!

## 📆 2025-07-07: Junior Programmer - Basic Gameplay Complete

### 🎮 New Functionality

- Pressing **S** spawns a random animal at a random position
- Camera **projection type** (Perspective / Orthographic) adjusted per project
- Animals now **spawn on a timed interval** and walk down the screen
- If an animal reaches the bottom of the screen, it triggers a **Game Over**
- If a projectile collides with an animal, **both are destroyed**
- Balls spawn randomly from the top of the screen
- Dogs are launched by the player as projectiles
- Balls are only destroyed upon **direct contact with dogs**
- Objects are destroyed based on their position:
  - Balls → off the bottom of the screen
  - Dogs → off the left side of the screen
- Bonus: **Spawn interval randomized** between 3 to 5 seconds

### 🧠 New Concepts & Skills Learned

- `Instantiate()` method structure and usage
- **Spawn Manager** script to handle randomized spawning
- Use of **arrays**, `KeyCode`, and **random number generation**
- Difference between **local** and **global** variables
- **Perspective vs Isometric** camera projection
- **Custom methods** and `InvokeRepeating()` for timed logic
- **Colliders and triggers** for object interaction
- **Override Unity functions** like `OnTriggerEnter()`
- Debugging using `Debug.Log()`
- Exporting Unity **packages**
- Creating and applying **custom materials**

### 🐛 Notable Debugging

- Issue: Projectiles (pizzas) disappeared when spawned from **Hierarchy-linked prefab**
  - Solution: Replaced with prefab from **Project folder**, not from Hierarchy

### 📌 Exercises

- ✅ Quizzes completed
- ❌ `Mod the Cube` exercise not yet completed (To Do)

### ✅ Milestone

- **Basic Gameplay section completed**

## 📆 2025-06-XX: Junior Programmer - Part 3: Sound and Effects (Nearly Complete)

### 🎮 New Functionality

- Player **jumps** when Spacebar is pressed
- **No double-jumping** allowed (uses boolean flags)
- Obstacles and background **move to the left**
- Obstacles **spawn at regular intervals**
- Background **repeats seamlessly**
- Spawning and background movement **stop upon player collision**
- Obstacles **destroyed off-screen**
- Player animations:
  - **Run** animation on start
  - **Jump** animation when jumping
  - **Fall** animation when crashing

### 🧠 Key Concepts and Skills

- `GetComponent<>` usage
- `ForceMode.Impulse` to apply jump force
- Gravity and `Rigidbody` component handling
- Rigidbody constraints and variables
- `OnCollisionEnter()` for collision detection
- `bool` (Boolean) usage and logic operators:
  - `&&` (AND)
  - `*=` (Multiply/Assign)
  - `==` (Equality)
  - `!` (NOT)
- **Script communication** using public variables and references
- **Tag comparison** using `CompareTag()`
- **Background loop** logic using collider width
- Unity **Animator Controller** setup:
  - Animation states, layers, and transitions
  - `SetTrigger()`, `SetBool()`, `SetInt()` to control animations via script

### ✅ Progress

- ✔️ All major features of Part 3 completed
- ❗ Final touches (e.g., sound integration) remaining
