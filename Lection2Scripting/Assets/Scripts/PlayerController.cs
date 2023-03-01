using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
   private float speed;

   public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        var v3 = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));
        transform.Translate(v3.normalized * (speed * Time.deltaTime),Space.World);

        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*5);
        }
        
        
        //inefficient way
        /*
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right*(speed*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-(speed * Time.deltaTime), 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, 0f, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0f, 0f, -(speed * Time.deltaTime));
        }
        */

       
    }
}
