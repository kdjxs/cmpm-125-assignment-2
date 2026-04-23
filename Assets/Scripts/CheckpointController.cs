using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;

public class CheckpointController : MonoBehaviour
{
    //int amtLaps = 0;
    public MeshRenderer flag;

    public CheckpointController next;
    public CheckpointController target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target.flag.materials[0].color = Color.red;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        VehicleController vehicle = other.gameObject.GetComponent<VehicleController>();
        if (vehicle != null)
        {

        }

    }
}
