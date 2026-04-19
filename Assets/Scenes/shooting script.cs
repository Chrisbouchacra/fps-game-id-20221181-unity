using UnityEngine;

public class PlayerShooting : MonoBehaviour {
    public float damage = 25f;
    public float range = 100f;
    public LayerMask enemyLayer; // Set this to the 'Enemy' layer in Unity

    void Update() {
        // Check if Left Mouse Button is clicked
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot() {
        RaycastHit hit;
        // Logic: Fire a ray from center of screen forward
        if (Physics.Raycast(transform.position, transform.forward, out hit, range)) {
            Debug.Log("Hit: " + hit.transform.name);

            // Look for the EnemyBase script on whatever we hit
            EnemyBase enemy = hit.transform.GetComponent<EnemyBase>();

            if (enemy != null) {
                // Call the function we defined in Step 3!
                enemy.TakeDamage(damage); 
            }
        }
    }
}