using UnityEngine;

public class PlayerMomentum : MonoBehaviour {

    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewaysforce = 500f;
    /*public bool onGround;
     // Use this for initialization
     void Start()
     {
         onGround = true;
         rb = GetComponent<Rigidbody>();
     }*/
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < 0.6f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        /*if (onGround)
        {
            if (Input.GetKey("w"))
            {
                rb.velocity = new Vector3(0f, 7f, 0f);
                onGround = false;
            }
        }*/
    }
    /*void OnCollisionEnter(Collision other)
   {
       if (other.gameObject.CompareTag("Ground"))
       {
           onGround = true;
       }
   }*/
}
