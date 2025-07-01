# 🎮 Unity Basic Learning Log

## 📘 Overview
This repository documents my learning process as I explore the fundamentals of the Unity game engine. Before diving into VR content development, the goal is to build a solid foundation in Unity’s core features, including its interface, object manipulation, component structure, and basic scripting.

## 📅 Start Date
June 5, 2025

## 🎯 Learning Goals
- Understand the Unity Editor interface
- Learn the concept of GameObjects and Components
- Practice scene composition and Hierarchy organization
- Gain familiarity with basic C# scripting in Unity
- Build a simple interactive environment as a foundation for VR

## 📂 Repository Structure
/Assets
/ProjectSettings
/Packages

## 🚀 Next Steps
- Complete Unity Learn’s beginner tutorials
- Create and manipulate basic 3D objects
- Experiment with materials, lighting, and camera control
- Prepare for VR-specific development after mastering the basics

---

Let me know if you'd like to add a progress log section or tailor it more toward VR from the start.

# 🎮 Unity Basic Learning Log

## 📆 2025-06-05 Learning Log

### 📚 Lesson: Unity Essentials - Master 3D Scene Navigation

### ✅ Summary of What I Learned
- How to frame a GameObject in the Scene view using the `F` shortcut.
- Navigating 3D space using Flythrough mode (right mouse + WASD keys).
- Zooming in and out in the Scene view using the scroll wheel.
- Orbiting around framed objects using the mouse and keyboard.
- Switching between Perspective and Isometric modes to change scene view.

---

### 🎮 Useful Unity Shortcuts

#### Scene View Navigation:
- **View**: Hold the right mouse button and drag.
- **Frame**: Press `F` in the Scene view or double-click a GameObject in the Hierarchy window.
- **Orbit**: Hold `Alt` (macOS: Option) + left mouse button drag.
- **Zoom**: Scroll wheel or hold `Alt` (Option) + right mouse button drag.
- **Flythrough mode**: Hold right mouse button + `WASD` keys (`Q`/`E` to move Down/Up).

#### Scene View Tool Shortcuts:
- **View**: `Q`
- **Move**: `W`
- **Rotate**: `E`
- **Scale**: `R`
- **Rect**: `T`

#### Miscellaneous Shortcuts:
- **Undo**: `Ctrl + Z` (macOS: `Cmd + Z`)
- **Save**: `Ctrl + S` (macOS: `Cmd + S`)

---

### 🚀 Notes
- Today I focused on mastering camera and object navigation within the Unity Scene view.
- Understanding these shortcuts will help speed up future VR content development.


## 📆 2025-06-06 Learning Log

### 📚 Lesson: Unity Essentials - Pass the Scene View Flying Test & Design a Mural in the Scene View

### ✅ Summary of What I Learned and Practiced
- Explained the difference between **Global** and **Local** coordinate space in the Scene view.
- Switched between **Global** and **Local** coordinates when positioning GameObjects.
- Moved objects using the **Move tool**.
- Rotated objects along axes using the **Rotate tool**.
- Switched between scene tools using the **QWERTY keyboard shortcuts**.
- Moved objects along one or two axes at a time using the **Move tool**.

### 🚀 Extra Practice
- Completed the **“More Things to Try”** section at the end of the tutorial.
- Successfully created the **Expert Slide** using all skills learned so far.
- Saved the scene after completing the exercise.

---

---

## 📆 2025-06-06 Learning Log (Continued)

### 🛠️ Scene Assembly Practice

- Imported the **Gizroom 3D scene** into the project.
- Placed the **Bedroom prefab** to create a room layout.
- Added and arranged the following prefabs:
  - 🛏️ **Bed**
  - 🏀 **Basketball Hoop**
  - 🐴 **Rocking Horse**
  - 🪟 **Bedroom base structure**
  - 🧶 **Carpet** and other interior props
- Practiced with the following tools for object placement:
  - `W` Move Tool
  - `E` Rotate Tool
  - `R` Scale Tool
- Adjusted position, rotation, and scale to build a furnished room layout.

---

---

## 📆 2025-06-07 Learning Log

### 🏀 Bounce Ball Scene Practice

Created a simple physics-based bouncing ball in Unity.

#### 🧱 What was built:
- Added a **3D Sphere primitive** to the scene.
- Customized the ball’s look with a new **Material**.
- Created and applied a **Physic Material** to adjust bounce behavior.
- Enabled realistic physics using the **Rigidbody** component.

#### 🔍 Skills practiced:
- Adding 3D primitives and describing their default behavior.
- Creating and editing **Materials** to change object appearance.
- Drag-and-drop material assignment from **Project window to Scene view**.
- Adding components like **Rigidbody** via the **Inspector**.
- Creating and assigning **Physic Materials** to define bounce and friction.
- Navigating and understanding the **Inspector window** layout.

---

## 📆 2025-06-XX: Prefab Tower & Physics Interaction

### 🧱 What I did today
- Created a **tower** using prefab blocks and knocked it over using a **ball** with physics.
- Reset the `Transform` component to position objects at the origin.
- Scaled objects using the **Scale tool**.
- Created a **Prefab** from an existing GameObject.
- Identified prefab instances in the Hierarchy window.
- Switched tool handle position between **Center** and **Pivot**.
- Edited a prefab in **Prefab Mode**.
- Assigned materials via the **Mesh Renderer** component.
- Created an **Empty GameObject** to serve as a parent.
- Organized objects using **Parent-Child** relationships in the Hierarchy window.

### ⚠️ Important Notes
- After creating a prefab from a GameObject in the scene, **the original object may not automatically stay linked** as an instance.
- To ensure prefab changes propagate, **always instantiate prefabs from the Project window**.


## 📆 2025-06-XX: Completed 3D Essentials & Audio Essentials Tutorials

### 🎮 3D Essentials - Final Sections Completed
- Positioned the **Main Camera** for ideal scene framing.
- Adjusted **Camera Field of View (FOV)**.
- Aligned the **Camera View to Scene View** using keyboard shortcuts.
- Adjusted the **Directional Light** to simulate time of day.
- Edited the **Skybox** to customize the scene’s background/environment.
- Changed the **Play Mode Tint** for better visual feedback when running the scene.
- ✅ Completed **"More Things to Try" (Medium difficulty)**.
- 🧠 Passed **Mission 2 Quiz**.

### 🔊 Audio Essentials - Completed
- Learned same key camera and lighting adjustments to prepare for audio scenes.
- ✅ Completed **"More Things to Try" (Medium difficulty)**.
- 🧠 Passed **Quiz 3**.

🎉 Both **3D Essentials** and **Audio Essentials** tutorials fully completed.

## 📆 2025-06-XX: Completed Programming Essentials in Unity

### 💻 What I Learned Today

- ✅ Created new C# scripts and attached them to GameObjects.
- ✅ Opened and edited code using Unity's default IDE.
- ✅ Made a **camera follow the player** using parenting structure.
- ✅ Temporarily adjusted component properties during **Play mode**.
- ✅ Understood `using` statements and class declaration.
- ✅ Learned about the `MonoBehaviour` base class.
- ✅ Used `Start()` and `Update()` methods for scripting behavior.
- ✅ Applied transform functions to move GameObjects over time.
- ✅ Practiced declaring variables using correct data types (`int`, `float`, `GameObject`).
- ✅ Declared custom variables and understood how public variables show in the Inspector.
- ✅ Learned and applied naming conventions (PascalCase vs camelCase).
- ✅ Used colliders as **triggers** and implemented `OnTriggerEnter()` for interaction.
- ✅ Used `Destroy()` to remove objects dynamically.
- ✅ Understood autocomplete features in the IDE for faster coding.
- ✅ Used **Visual Effects (VFX)** for user feedback.
- ✅ Implemented `Instantiate()` to spawn prefabs in runtime.
- ✅ Used snapping and alignment tools in the Scene view.
- ✅ Applied conditional logic using `if` statements.
- ✅ Tagged GameObjects and accessed them in code using `CompareTag()`.

### 📌 Quiz Summary
- ✅ Completed the **Programming Essentials quiz**.
- ❌ One mistake: misunderstood how `Instantiate()` works.
  
### 📘 Clarification: How `Instantiate()` Works
The `Instantiate()` function is used to create a copy of a prefab or GameObject at runtime.
```csharp
Instantiate(prefab, position, rotation);
This will spawn the object at the given position and rotation. You can also store the result in a variable to modify or track the instance later.

---

## 📆 2025-06-XX: Completed 2D Essentials in Unity

### 🧩 What I Learned Today

- 🔄 Switched between **2D view** and **3D view** in the Scene window.
- 🧭 Compared navigation differences between 2D space and 3D space.
- 🖼️ **Defined sprite** and used sprites in a 2D environment.
- 🧪 Adjusted Game view **aspect ratio** to match user devices.
- 🔲 Used the **Rect Tool** to move, resize, and scale 2D objects.
- 📐 Learned the difference between **2D Colliders** and **3D Colliders**.
- 📑 Duplicated GameObjects for fast level design.
- 🎨 Used `Order in Layer` to control visual stacking in 2D scenes.
- 🔳 Explained how **9-sliced sprites** work for resizable UI elements.
- ⚙️ Adjusted `Rigidbody2D` properties:
  - `Mass`: controls weight
  - `Linear Drag`: slows down movement
  - `Angular Drag`: slows down rotation

### 💡 Important Note
> `Rigidbody2D` uses **2D physics**, so its interactions require **2D physics functions**, not 3D ones like `OnCollisionEnter` but rather `OnCollisionEnter2D`.

### 🎞️ Sprite Sheet & Animation

- 🧵 Defined **sprite sheet** and how it enables 2D animation.
- ✂️ Sliced a sprite sheet into individual frames using **Sprite Editor**.
- 🔁 Created a **looping animated sprite** from sliced frames.

---

### 📝 Quiz Review

**❌ Mistake:**
- **Q:** What happens when you turn on 2D mode in the Scene view?
- **Incorrect understanding**: Thought it simply disables 3D view.
- **✅ Correct answer:**
  > *Turns off perspective and orients the camera to look towards positive Z, with the X-axis pointing right and the Y-axis pointing up.*

This was an important concept to visualize and remember for proper 2D layout understanding.

