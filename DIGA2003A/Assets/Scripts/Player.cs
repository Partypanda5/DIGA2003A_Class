using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement
    private Animator animator;   // Reference to Animator component
    bool isWalking = false;      // Start as false

    void Start()
    {
        animator = GetComponent<Animator>(); // Get the Animator on the player
    }

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;
        isWalking = false; // make sure isWalking is consistently false unless we press left or right or a or d

        // Check for WASD and Arrow Key inputs
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection.y += 1;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection.y -= 1;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection.x -= 1;
            isWalking = true; // set the isWalking bool to true
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z); // Flip the sprite left
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection.x += 1;
            isWalking = true; // set the isWalking bool to true
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z); // Flip the sprite right
        }

        // Move the player
        transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;

        // Set animation bool to true or false, depending on if the player is pressing left, right, a or d OR not pressing anything
        animator.SetBool("Walk", isWalking);
    }
}