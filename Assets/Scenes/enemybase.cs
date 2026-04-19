
    using UnityEngine;
using UnityEngine.AI; // For NavMesh movement

public class EnemyBase : MonoBehaviour {
    public float health = 50f;
    public float speed = 3.5f;
    public int scoreValue = 10;
    
    protected Transform player;
    protected NavMeshAgent agent;

    public virtual void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
    }

    public virtual void Update() {
        if (player != null) agent.SetDestination(player.position); // Chase logic
    }

    public void TakeDamage(float amount) {
        health -= amount; // Assignment operator
        if (health <= 0) Die();
    }

    void Die() {
        // Add code here to update the score
        Destroy(gameObject); 
    }
}
}
