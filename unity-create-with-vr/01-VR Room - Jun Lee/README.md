## 🗓️ Daily Log – 2025-05-30

### ✅ Summary of Activities
Today was my first hands-on session with the **Unity Create with VR** course (VR Basics section). Here's what I accomplished:

- Opened the provided `VR Room` project folder and renamed it to `VR Room - Jun Lee`.
- Launched the project in Unity and explored pre-loaded assets and packages prepared for the tutorial.
- Loaded the default scene and observed that basic XR setup such as XR Rig and interaction components were already placed in the Hierarchy.
- Learned how to inspect components, their properties, and interaction behaviors.
- Added background environment and objects (walls, props, etc.) to the scene using the available assets.
- Played the scene inside the Unity Editor (PC Mode).
- Connected my **Meta Quest 3** using **AirLink**, tested scene playback — learned how the headset receives VR feed.
- Discovered that **Android Build & Run requires USB connection**, not AirLink.
- Installed Android Build Support and tested building the project to Meta Quest 3 via USB.

### 💡 Key Learnings
- Unity's Hierarchy & Inspector are powerful for real-time scene composition.
- Understanding XR Rig structure is foundational for all future VR interaction design.
- Meta Quest 3 requires USB for Android build targets due to ADB connection requirements.
- AirLink is only suitable for streaming, not device flashing or ADB-level deployment.

---

## 📆 2025-06-05 Development Log

### 🎯 What I learned and practiced today
- Placed a **fireplace** and **mirror** in the room using the provided prefabs
- Added the following components to the `XR Rig`:
  - ✅ `Locomotion System`
  - ✅ `Continuous Turn Provider`, `Snap Turn Provider` for rotating viewpoint
  - ✅ `Teleportation Provider` for enabling teleport movement
- Added `Teleportation Area` to floor plane and other objects
- Applied a **Reticle** prefab to visualize the teleportation target

### ✅ Key takeaway
- **Teleportation Area requires a Collider to function**
  - It won't work without a `Mesh Collider`
  - The `isTrigger` option must be **disabled**

### ⚠️ Current issue
- When using the **OpenXR** plugin, the VR scene does **not launch properly** on Meta Quest 3 via **Air Link**
  - It works fine with the **Oculus Plugin**
  - The course also **recommends using a cable connection** for this part
