using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SidewayForce = 700f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce( 0 , 0 , ForwardForce * Time.deltaTime);

        //right movement
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewayForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        //left movement
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewayForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        if(rb.position.y < -1.0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
