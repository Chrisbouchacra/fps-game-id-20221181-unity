
    using UnityEngine;

// Inherits everything from EnemyBase
public class Grunt : EnemyBase 
{
    public override void Start() 
    {
        // Set stats for the Grunt
        health = 50f;
        speed = 3.5f;
        scoreValue = 10;

        // Call the Start() method in EnemyBase to setup NavMesh/Player reference
        base.Start(); 
    }
}
}
