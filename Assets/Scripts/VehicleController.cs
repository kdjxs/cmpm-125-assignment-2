using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class VehicleController : MonoBehaviour
{
    float forward = 1;
    float side = 0;
    float starttime;
    public float impulse;
    public float sideImpulse;
    public CheckpointController target;
    public TextMeshProUGUI timelbl;

    public coinManager cm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //amtLaps = 0;
       //starttime = Time.time;
       //laps.text = "Lap: " + amtLaps;
       //target = GetComponent<CheckpointController>();
    }

    // Update is called once per frame
    void Update()
    {
        //timelbl.text = string.Format("Current time: {0:F2} seconds", (Time.time - starttime));
        var rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(forward * impulse, 0, 0);
        rb.AddRelativeForce(0, 0, side * sideImpulse);

    }
    void OnMove(InputValue action)
    {
        var movement = action.Get<Vector2>();
        forward = movement.y;
        side = movement.x;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CoinTrigger"))
        {
            Destroy(other.gameObject);
            cm.coinCount++;
        }
    }

}
