using UnityEngine; // Import the UnityEngine library, which provides access to Unity’s core classes and functions.

public class TunnelMovement : MonoBehaviour
{
    public float rotationspeed = 90f;
    // A public float variable that stores the rotation speed of the tunnel
    // Because it's public, you can also adjust it in the Unity Inspector.
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) // Check if the Right Arrow key is being held down
        {
            // Rotate the object clockwise around the Z-axis.
            // Negative value rotates in clockwise direction
            transform.Rotate(0f, 0f, -rotationspeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)) // Check if the Left Arrow key is being held down
        {
            // Rotate the object counter-clockwise around the Z-axis
            transform.Rotate(0f, 0f, rotationspeed * Time.deltaTime);
        }
    }
}