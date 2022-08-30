using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera cineVC;
    Vector3 carTransform;
    [SerializeField] CarMechanics car;

    // Start is called before the first frame update
    void Start()
    {
        cineVC = GetComponent<CinemachineVirtualCamera>();
        carTransform = car.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cineVC.ForceCameraPosition(new Vector3(0, carTransform.y, 0), Quaternion.identity);
    }
}
