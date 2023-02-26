using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkDestruction : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject explosionObject;

   // [SerializeField] private Transform explosionPosition;
    void Start()
    {
        Destroy(gameObject,0.2f);
       
    }

    private void OnDestroy()
    {
        var o = gameObject;
        var explosion = Instantiate(explosionObject, o.transform.position, o.transform.rotation);
        Destroy(explosion,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
