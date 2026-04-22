//using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    int amtLaps = 0;
    float desired_acceleration = 0;
    float starttime;
    public float impulse;
    float steering;
    public CheckpointController target;
    public TextMeshProUGUI timelbl;
    public TextMeshProUGUI laps;
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
        // timelbl.text = string.Format("Current time: {0:F2} seconds", (Time.time - starttime));

        GetComponent<Rigidbody>().AddRelativeForce(desired_acceleration * impulse, 0, 0);
        transform.Rotate(0, steering * 100f * Time.deltaTime, 0);
    }
    void OnMove(InputValue action)
    {
        
        var movement = action.Get<Vector2>();
        desired_acceleration = movement.y;
        steering = movement.x;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CoinTrigger"))
        {
            Destroy(other.gameObject);
            cm.coinCount++;
        }
    }

    //    private void OnTriggerEnter(Collider other)
    //    {
    //        if (other.CompareTag("LapTrigger"))
    //        {
    //            amtLaps++;
    //            laps.text = "Lap: " + amtLaps;
    //        }
    //    }
}
