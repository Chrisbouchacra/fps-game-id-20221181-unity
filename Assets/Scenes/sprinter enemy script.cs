using UnityEngine;

public class sprinterenemyscript
{
    // Just two lines of code for a new type!
public class Sprinter : EnemyBase {
    public override void Start() {
        health = 20; speed = 8; scoreValue = 20;
        base.Start(); // Run the shared setup logic
    }
}
}
