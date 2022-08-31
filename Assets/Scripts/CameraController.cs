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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
