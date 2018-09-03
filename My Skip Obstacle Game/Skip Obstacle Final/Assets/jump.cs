using UnityEngine;

public class jump : MonoBehaviour
{

    private Rigidbody rb;
    public bool onGround;
    // Use this for initialization
    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (onGround)
        {
            if (Input.GetKey("w"))
            {
                rb.velocity = new Vector3(0f, 7f, 0f);
                onGround = false;
            }
        }
       // onGround = true;
    }
    void OnCollisionEnter(Collision other)
   {
        // if (other.gameObject.CompareTag("Ground"))
        if (other.gameObject.CompareTag("Ground"));
        {
           onGround = true;
       }
   }
}
