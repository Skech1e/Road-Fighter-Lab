using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Behaviour : MonoBehaviour
{
    Rigidbody2D rigidbody;

    private void Awake()
    {
       rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    

    void Movement()
    {
        rigidbody.velocity = Vector3.up * 6.9f;
    }
}
