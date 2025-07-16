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

## 📆 2025-07-09: Junior Programmer - Part 3: Sound and Effects (Nearly Complete)

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


## 📆 2025-07-09: Junior Programmer - Part 3: Sound and Effects (Completed)

### 🎮 New Functionality

- 🎵 **Background music** plays during the game
- ✨ **Particle effects** at the player’s feet while running
- 💥 **Sound effects and explosion** when the player hits an obstacle

### 🧠 Key Concepts and Skills

- Unity **Particle Systems** usage
- Positioning **child objects** for effects (e.g., particle system under player)
- Working with **Audio Clips** and **Audio Source** components
- Using code to **play/stop sound effects**

### ✅ Progress Summary

- 🧪 Completed `Challenge 3` — fixed bugs based on prior learning
- 🎧 Finished sound & particle effects implementation
- 🧠 `Quiz 3` completed successfully
- 🧩 `Creative Code Lab 3` **not attempted yet**

### 🌟 Overall Recap

- Built a polished and feature-rich game:
  - Endless scrolling background
  - Smooth character animations
  - Interactive jumping & collision logic
  - Full sound and visual feedback through music, VFX, and SFX

## 📆 2025-07-10: Junior Programmer - Part 4: Game Mechanics (Completed)

### 🎮 New Functionality

#### 🌀 Camera & Player Movement
- Camera rotates around the island using horizontal input
- Player rolls forward/backward based on camera orientation and vertical input

#### 👾 Enemy Interaction
- Enemies spawn at random positions and follow the player
- Physics-based bouncing between spheres

#### ⚡ Powerup System
- Visual indicator appears when player collects a powerup
- Powered-up player can knock enemies away
- Powerup effect wears off after a few seconds

#### 🔁 Enemy Waves
- Enemies spawn in waves
- Each wave increases in enemy count
- A new powerup spawns with each wave

### 🧠 Key Concepts and Skills

- Texture wrapping and camera hierarchy
- Global vs local coordinates, direction calculations
- Physics Materials, vector normalization
- Return values in methods
- Coroutines using `IEnumerator` and `WaitForSeconds()`
- Object activation with `SetActive(true/false)`
- For-loops, `++` operator, parameterized methods
- `FindObjectsOfType()` for wave management

### ✅ Progress Summary

- ✅ Completed `Challenge: Soccer Scripting`
- ✅ Finished `Quiz 4`
- ❌ `Creative Lab 4` not completed yet
- ⚠️ **Note:** Forgot to save `Prototype 4` project. Need to **rebuild from scratch**. Remember to **frequently save your Unity projects** to avoid data loss!

## Part 5: User Interface (In Progress)

### Date: 2025-07-11

---

### 🎮 New Functionality

- Random objects are tossed into the air on intervals.
- Objects are given random speed, position, and torque.
- If you click on an object, it is destroyed.

#### 🧠 New Concepts and Skills

- 2D View  
- `AddTorque`  
- Game Manager  
- Lists  
- While Loops  
- Mouse Events  

---

- There is a UI element for score on the screen.
- The player’s score is tracked and displayed by the score text when hitting a target.
- There are particle explosions when the player gets an object.

#### 🧠 New Concepts and Skills

- TextMeshPro  
- Canvas  
- Anchor Points  
- Import Libraries  
- Custom methods with parameters  
- Calling methods from other scripts  

---

- A functional Game Over screen with a Restart button.
- When the Restart button is clicked, the game resets.

#### 🧠 New Concepts and Skills

- Game States  
- Buttons  
- On Click events  
- Scene Management Library  
- UI Library  
- Booleans to control game states  

---

- Title screen that lets the user start the game.
- Difficulty selection that affects spawn rate.

#### 🧠 New Concepts and Skills

- `AddListener()`  
- Passing parameters between scripts  
- Divide/Assign (`/=`) operator  
- Grouping child objects  

---

### ⚠️ Trigger vs Collision Summary (Target Object Collision Issue)

**📌 Problem**  
The `OnTriggerEnter()` function was being called when **target objects collided with each other**, causing an unintended Game Over.  
However, the intended behavior was to **trigger Game Over only when a target falls to the ground**.

**✅ Root Cause**
- `isTrigger` was enabled on the target objects → simply overlapping triggered `OnTriggerEnter()`
- If `gameObject.CompareTag("Bad")` check failed, the `GameOver()` function was called

**🛠 Solution**
- **Target Objects**: Keep `Rigidbody` attached, but disable `isTrigger` (unchecked) → collisions between targets no longer trigger events
- **Ground Detector (e.g., Sensor)**: Enable `isTrigger` (checked)
- **Updated Script Example**:

```csharp
private void OnTriggerEnter(Collider other)
{
    Destroy(gameObject);

    // Trigger Game Over only when hitting the ground (Sensor)
    if (!gameObject.CompareTag("Bad"))
    {
        gameManager.GameOver();
    }
}

**✅ Result**
- Target objects colliding with each other no longer trigger Game Over
- Game Over is triggered only when a target touches the ground (Sensor) via OnTriggerEnter()


## 📆 2025-07-15 Development Log

### 🗂️ Part 6: Publishing Your Project (6.1 using prototype 1)

Today I resumed the Unity Junior Programmer course after a break due to Unity Learn system maintenance.

#### 🎯 New Concepts and Skills Learned

- **Optimization Basics**  
  Understanding how to optimize game performance for better efficiency.
  
- **Serialized Fields**  
  Using `[SerializeField]` to expose private fields in the Inspector while keeping encapsulation.

- **Keywords:**
  - `readonly`  
  - `const`  
  - `static`  
  - `protected`  
  Learning when and how to use these modifiers for cleaner and safer code.

- **Event Functions Overview**
  - `FixedUpdate()` vs. `Update()` vs. `LateUpdate()`  
    → Learn the execution order and best use cases.
  - `Awake()` vs. `Start()`  
    → Understand when each is called during the object lifecycle.

- **Object Pooling**  
  Reusing inactive objects instead of creating and destroying them repeatedly to improve performance.

---

### 📝 Note:
- This marks the start of **Part 6: Publishing Your Project (6.1)**  
- Will continue to the next sections tomorrow.

## 📆 2025-07-16 Development Log

### 🗂️ Part 6: Publishing Your Project (Continued)

#### 🎯 New Concepts and Skills Learned

- **Community Support & Documentation**
  - How to search effectively on **Unity Answers**, **Unity Forum**, and **Unity Scripting API**
  - Troubleshooting and resolving bugs by using online resources

- **Physics & Math Functions**
  - `AddRelativeForce()`
  - Adjusting **Center of Mass** for physics stability
  - `Mathf.RoundToInt()`

- **Operators & Loops**
  - Using **Modulus (%)** operator for loop control and logic
  - Looping through **Lists**

- **Custom Methods**
  - Creating custom methods that **return `bool` values** for conditional logic

---

### ⚠️ Note:
- Today's session is **partially incomplete**, and certain sections may need to be revisited for review and refinement later.
