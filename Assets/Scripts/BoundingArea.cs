using UnityEngine;

public class BoundingArea : MonoBehaviour
{
    public Vector3 SpawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("BoundObj"))
        {
            other.gameObject.transform.position = SpawnPoint;
            //other.attachedRigidbody.velocity = Vector3.zero;
            other.attachedRigidbody.angularVelocity = Vector3.zero;
        }
    }
}
