using TMPro; // Import the TextMeshPro library
using UnityEngine; // Import the UnityEngine library, which provides access to Unity’s core classes and functions.

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb; // Private variable to store the Rigidbody component reference for physics manipulations
    private bool gravityInverted = false;  // Tracks whether gravity is currently inverted (false = normal, true = inverted)
    public float gravityMultiplier = 10f; // Multiplier to scale the gravity
    public float movementSpeed = 15f;  // Player’s constant forward speed
    public TMP_Text scoreMessage;  // Reference to a TextMeshPro text UI element for displaying the score
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get and store the Rigidbody component attached to the player
        
        // Initialize gravity, scaled by gravityMultiplier, directed downwards so that the player doesn't start on top
        Physics.gravity = gravityMultiplier * Vector3.down * 9.81f;
    }

    // Update is called once per frame
    void Update()
    {
        //Move the player continuously forward along the Z-axis at the speed defined by movementSpeed.
        void FixedUpdate()
         {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, movementSpeed);
         }
        
        // Calculate the current gravity value based on multiplier.
        float gravityValue = 9.81f * gravityMultiplier;    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravityInverted = !gravityInverted; // Toggle the gravity direction.
            if(gravityInverted == true)
                Physics.gravity = gravityValue * Vector3.up; // Set gravity upwards
            else
                Physics.gravity = gravityValue * Vector3.down; // Set gravity downwards
        }
        scoreMessage.text = "Score: " + ComputeScore(); // Update the on-screen text to display the current score.
    }
    private int ComputeScore()
    {
        return Mathf.RoundToInt(transform.position.z);
        // Compute the score by rounding the player’s Z-position to the nearest integer.
    }
}