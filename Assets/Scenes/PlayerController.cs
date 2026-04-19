
    using UnityEngine;
using UnityEngine.UI; // Required for Slider
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float health = 100f; // Using float for precision
    public Slider healthSlider;

    void Start() {
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }

    public void TakeDamage(float amount) {
        health -= amount; // Assignment operator
        healthSlider.value = health;

        if (health <= 0) { // Relational operator for death check
            SceneManager.LoadScene("GameOver"); // Requirement 1
        }
    }
}
}
