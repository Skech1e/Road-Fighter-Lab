using UnityEngine;

public class CarMechanics : MonoBehaviour
{
    CarControls carControls;
    [SerializeField]Vector2 move;
    [SerializeField] float speed;
    [SerializeField] float boost;
    Rigidbody2D rigidBodyCar;
    private void Awake()
    {
        carControls = new CarControls();
        speed = 15f;
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
        move = carControls.Car.Move.ReadValue<Vector2>();
        move.y = Vector2.up.y * boost;
        boost = carControls.Car.BoostSlow.ReadValue<float>();
        boost++;

        rigidBodyCar.velocity = move * speed;

    }
}
