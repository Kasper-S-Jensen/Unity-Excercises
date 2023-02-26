using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShootFireworks : MonoBehaviour
{
    [SerializeField] private Rigidbody projectile;
    [SerializeField] private Transform barrelEnd;
    [SerializeField] private int speed;
        
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Rigidbody projectile1 = Instantiate(projectile,barrelEnd.position,barrelEnd.rotation);
            projectile1.AddForce(barrelEnd.up*speed);
          
        }
    }
}
