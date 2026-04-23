using UnityEngine;

public class RespawnCheckpoint : MonoBehaviour
{
    public Vector3 respawnPoint;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision player)
    {
        if (gameObject.CompareTag("voidTrigger"))
        {
            player.transform.position = respawnPoint;
        }
    }
}
