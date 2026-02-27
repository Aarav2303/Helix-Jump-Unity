using UnityEngine; // Import the UnityEngine library, which provides access to Unity’s core classes and functions.

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // A public reference to the player GameObject
    
    public Vector3 offset = new Vector3(0,0,-7); // A Vector3 representing the positional offset from the player
    // Default offset moves the following object 7 units behind the player on the Z-axis.
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z = player.transform.position.z + offset.z;
        transform.position = newPosition;
		    // Update the position of the camera
		    // Keeps X and Y unchanged (so the camera doesn't move vertically or sideways),  
        // but adjusts Z to always follow the player's Z position plus the offset.  
    }
}