# fps-game-id-20221181-unity
PROJECT OVERVIEW &
DOCUMENTATION
Unity Wave-Based Combat System
1. PROJECT ARCHITECTURE
This project implements a modular enemy wave system with a focus on inheritance-based AI
and player interaction. The architecture is designed for scalability, allowing for rapid expansion
of enemy types and game states.
Engine Unity 2021.3+ Language C# System NavMesh AI 
2. CORE SCRIPTS DOCUMENTATION
GameManager.cs
Manages high-level game state transitions using the SceneManager API. Handles scene
switching between the Main Menu, Gameplay, and Restart logic.
PlayerController.cs
Handles player vitals and UI synchronization. It utilizes a Slider component for health
visualization and triggers the 'GameOver' sequence upon health depletion.
Enemy System (Inheritance Hierarchy)
The enemy system uses a Base-Class approach to ensure consistent behavior across
different units:
EnemyBase: The parent class containing the core NavMesh pathfinding and 
TakeDamage logic.
Grunt: Standard balanced unit.
• 
• 
Tank: High-health, low-speed unit with a 2x scale modifier.
Sprinter: Low-health, high-speed unit for flanking.
WaveManager.cs
A dynamic spawning system that escalates difficulty by increasing enemy counts per wave. It
utilizes Generics (List<GameObject>) to randomly select and instantiate enemy prefabs
at designated spawn points.
3. SETUP INSTRUCTIONS
Script-to-Filename Requirement: In Unity, the Class Name and Filename MUST
match exactly. Ensure all scripts are named according to their class (e.g., 
WaveManager.cs). 
NavMesh: Bake a NavMesh in your scene (Window > AI > Navigation) so enemies can
move.
Tags: Ensure your Player object is tagged with "Player".
UI: Assign a Slider component to the healthSlider slot in the PlayerController
inspector.
Prefabs: Drag your enemy variants into the enemyPrefabs list on the WaveManager.
4. TECHNICAL SPECIFICATIONS
The code utilizes several advanced C# and Unity features:
Polymorphism: Virtual/Override methods for unique enemy behavior.
Namespaces:UnityEngine.AI for pathfinding and UnityEngine.UI for interface
management.
Delegates/Expression-bodied members: Concise logic for scene transitions.
Technical Documentation © 2026 | Unity Development Repository 
• 
• 
1. 
2. 
3. 
4. 
• 
• 
• 
