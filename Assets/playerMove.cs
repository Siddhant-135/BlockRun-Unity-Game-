using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Rigidbody rb;
    public manager manager;
    // Important variables 
    private int leftRightForce = 20;
    private float forwardForce = 0.9f;
    private float forwardSpeed = 20f;
    // Temporary stuffs 
    int horizontalInput = 0;
    int prevInput = 0;
    //float timer = 0f;

    void Start()
    {
        Debug.Log("Hello world");
        rb.linearVelocity = new Vector3(forwardSpeed,0,0);
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            horizontalInput = -1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            horizontalInput = 1;
        }
        else {
            horizontalInput = 0;
        }

        // timer += Time.deltaTime;
        // if (timer >= 1f)
        // {
        //     Debug.Log(rb.linearVelocity);
        //     timer = 0f;
        // }

    }

    void FixedUpdate()
    {
        rb.AddForce(forwardForce,0,horizontalInput * leftRightForce);

        if (horizontalInput != prevInput || horizontalInput == 0) {
            rb.linearVelocity = new Vector3 (rb.linearVelocity.x,rb.linearVelocity.y,0);
        }
        prevInput = horizontalInput;

        if (rb.position.y < -0.2f) {
            manager.gameOver();
        }
    }
}
