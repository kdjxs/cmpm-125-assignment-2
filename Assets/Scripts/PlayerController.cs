//using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    float desired_acceleration = 0;
    float starttime;
    public float impulse;
    float steering;
    public TextMeshProUGUI timelbl;
    public TextMeshProUGUI laps;
    public coinManager cm;
    public GameObject Player;
    public GameObject RespawnPoint; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        starttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // Display current time
        timelbl.text = string.Format("Current time: {0:F2}", (Time.time - starttime));

        // Add force to player
        GetComponent<Rigidbody>().AddRelativeForce(desired_acceleration * impulse, 0, 0);
        // Camera turn with A and D
        transform.Rotate(0, steering * 100f * Time.deltaTime, 0);

    }
    // When the player uses W and S
    void OnMove(InputValue action)
    {
        
        var movement = action.Get<Vector2>();
        desired_acceleration = movement.y;
        steering = movement.x;
    }

    // When R button is pressed
    void OnRestart(InputValue action)
    {
        Player.transform.position = RespawnPoint.transform.position;
        GetComponent<Rigidbody>().AddRelativeForce(0, 0, 0);
        starttime = Time.time;
    }

    // Player touches coin
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CoinTrigger"))
        {
            Destroy(other.gameObject);
            cm.coinCount++;
        }
    }
}
