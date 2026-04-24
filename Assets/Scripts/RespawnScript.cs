using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject RespawnPoint;

    // Spawn player at respawn point
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.transform.position = RespawnPoint.transform.position;
        }
    }
}
