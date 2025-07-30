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
