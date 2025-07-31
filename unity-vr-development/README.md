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
