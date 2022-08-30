using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMechanics : MonoBehaviour
{
    CarControls carControls;
    Vector2 move;
    float speed;
    Rigidbody2D rigidBodyCar;
    private void Awake()
    {
        carControls = new CarControls();
        speed = 10f;
        rigidBodyCar = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        carControls.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        Movement();
    }

    void Movement()
    {
        move = carControls.Car.Move.ReadValue<Vector2>() * speed;
        rigidBodyCar.velocity = move;
    }
}
