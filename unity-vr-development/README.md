## 📆 2025-07-30

### ✅ Today’s Progress: VR Project Setup (Unity VR Development Pathway)

- **Started**: Unity VR Development Pathway
- **Project File**: `Create with VR Starter Project`
- **Scene Renamed**: `Assets/Scenes/StarterScene` → `Jun Room`
- **XR Rig Configuration**:
  - Changed `Tracking Origin Mode` to `Floor`
- **Using Oculus VR Headset**:
  - Successfully ran VR in Play Mode on Windows
- **Project Settings**:
  - Enabled `OpenXR` under `Edit > Project Settings > XR Plug-in Management`
  - Clicked the warning icon to create an `Oculus Controller Profile`
- **🚨 Critical Issue Discovered**:
  - If `Mock Runtime` under `OpenXR Feature Groups` is enabled, Quest 3 **does not work**
  - ✅ Disabling `Mock Runtime` resolves the issue and enables proper VR rendering on Quest 3
  - This was **not mentioned** in the Unity Learn tutorial — will report this as feedback
- **Built & Ran on Quest 3**:
  - Successfully deployed as Android app and tested on the headset

---

### 🧠 Note

- Completed the `VR Project Setup` section today.
- Although the tutorial was familiar from a previous "Create with VR" course, I restarted from scratch to reinforce my understanding.

## 📆 2025-07-31

### ✅ Today’s Progress: VR Locomotion Setup

Building on yesterday’s setup, I explored different locomotion techniques in VR. Here's a breakdown of what was covered:

---

### 🏠 Scene Setup
- Added various props to the room such as furniture and rugs for spatial context.

---

### 🏃‍♂️ XR Locomotion Types Learned

1. **Room-Scale Movement**  
   - User physically walks around in the real-world play space. No additional setup required if the space allows.

2. **Continuous Movement (Joystick-based)**
   - **XR Rig**:
     - Selected the `XR Rig` object.
     - Added the `Locomotion System` component.
     - Dragged the `XR Origin` into the Locomotion System's XR Origin field.
   - **Turn Provider**:
     - Added either `Snap Turn Provider` or `Continuous Turn Provider` to the XR Rig.
     - Dragged the `Locomotion System` into the Turn Provider's Locomotion System field.
     - This enables controller-based rotational movement.

3. **Teleportation Movement**
   - Added the `Teleportation Provider` component to the XR Rig.
   - Assigned the same `Locomotion System` to it.
   - Marked interactable ground objects (like rugs or floor) with a `Teleportation Area` component.
   - This enables the player to point and teleport to allowed areas.

---

### ✨ Summary
- Successfully implemented all three locomotion types.
- Practiced setting up movement interaction zones.
- Enabled turning and teleportation using controller inputs.

---

### 🔗 Next Steps
- Test transitions between different locomotion methods.
- Explore smooth locomotion comfort settings.


## 📆 2025-08-01

### ✅ Today’s Progress: Grabbable Objects in VR

In Part 1.3 of the VR Development Pathway, I learned how to set up interactive grabbable objects using XR Interaction Toolkit in Unity.

---

### 👐 Hand Models Setup

- **Added Hand Models**:  
  - From the `VR` folder, assigned the `Hand` prefab to the left and right XR Controller components under `XR Rig`.
  - This displays hand models in VR.

---

### ⚠️ Teleportation Bug (Camera Dropping to Floor)

- **Issue**:  
  - During teleportation, the camera would sink into the floor.
- **Fix**:  
  - Changed `XR Rig`'s **Tracking Origin Mode** from `Floor` to `Device`.

---

### 🎾 Added Interactable Tennis Equipment

- **Tennis Ball & Racket**:
  - Imported from `Sports` folder and added to the scene.
  - Assigned `XR Grab Interactable` component to both.

- **XR Interaction Manager**:
  - Added to the scene and referenced by the interactables.

---

### 🛠 Object-Specific Settings

- **Racket**:
  - Enabled `Attach Transform` for better hand alignment.
  - Disabled `Hide Controller on Select` in **Selection Configuration** to hide the hand model when grabbing.

- **Tennis Ball**:
  - Added `Sphere Collider` for accurate collision.
  - Added a `Physics Material` to allow for bouncing.
  - Enabled `Collision Detection` for realistic physics behavior.

- **Hand Visibility**:
  - Disabled `Anchor Control` to ensure the hands don't shift unexpectedly when grabbing.
  - Made sure controller is hidden when grabbing for realism.

---

### ✅ Summary

- Hands appear and track properly in VR.
- Grabbable objects (racket & ball) behave realistically with proper physics and hand alignment.
- Fixed camera sinking issue.

## 📆 2025-08-04

### ✅ Today’s Progress: Socket Interactions in VR

In Part 1.4 of the VR Development Pathway, I learned how to set up sockets for placing grabbable objects (hats) onto designated holders (hooks).

---

### 🧢 Added Grabbable Hats

- **Hats**:
  - Added two hat objects to the VR room scene.
  - Assigned `XR Grab Interactable` component to each hat to make them grabbable.

---

### 🪝 Created Socket Hook Setup

- **Hook Setup**:
  - Under the `Hook` object, created a child named `Socket`.
  - Added a **Collider** (e.g., Box or Sphere Collider) to the `Socket`.
  - Added `XR Socket Interactor` component to the `Socket`.

---

### 📍 Attach Point Alignment

- **Attach Transform**:
  - Created a new empty GameObject called `Attach` under the `Socket`.
  - Assigned this `Attach` GameObject to the **Attach Transform** field of the `XR Socket Interactor`.
  - This ensured that the hats snap into the correct position and rotation when placed into the socket.

---

### ✅ Summary

- Hats can be picked up and snapped onto the hooks.
- Sockets properly receive objects and align them using custom attach points.
- Scene now includes working socket interactions using `XR Socket Interactor`.