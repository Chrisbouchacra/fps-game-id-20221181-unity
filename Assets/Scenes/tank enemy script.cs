
    using UnityEngine;

public class Tank : EnemyBase 
{
    public override void Start() 
    {
        // Set stats for the Tank
        health = 250f;    // 5x Grunt health
        speed = 1.5f;     // Much slower
        scoreValue = 50;  // Worth more points

        // Visual distinction: Make the Tank bigger
        transform.localScale = new Vector3(2f, 2f, 2f);

        base.Start();
    }

    // Optional: Override TakeDamage to show a different effect for big hits
    public override void TakeDamage(float amount)
    {
        Debug.Log("The Tank absorbed some damage!");
        base.TakeDamage(amount);
    }
}
}
