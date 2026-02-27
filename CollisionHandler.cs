using UnityEngine; // Import the UnityEngine library, which provides access to Unity’s core classes and functions.
using UnityEngine.SceneManagement; // Import the SceneManagement library to allow reloading or switching between scenes.

public class CollisionHandler : MonoBehaviour
{
    public Behaviour playerMovementScript;
    // A public reference to the PlayerMovement script that allows access to enable/disable the player’s movement logic when collisions occur.
    private void OnCollisionEnter(Collision collision)
    // Unity event method that is automatically called when this GameObject collides with another GameObject
    {
        // Check if the collided object has the tag "Obstacle" OR "Endblock"
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Endblock"))
        {
            // Calls RestartGame() after 2 seconds.
            Invoke(nameof(RestartGame), 2f);
            // Disables the player’s movement script, disabling the player movement on collision.
            playerMovementScript.enabled = false;
        }
    }
    public void RestartGame()
    {
        // Reloads the currently active scene by fetching its name to restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        // Re-enables the player’s movement script after restart
        playerMovementScript.enabled = true;
    }
}
