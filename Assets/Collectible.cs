using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Variables 
    public float timeUntilRespawn;
    public int points;
    // Methods
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            points++;
            gameObject.SetActive(false);
            Invoke("enableCollectible", timeUntilRespawn);
        }
    }

    private void enableCollectible()
    {
        gameObject.SetActive(true);
    }

    private void Update() // For Rotating Collectible
    {
        gameObject.transform.Rotate(Vector3.forward);
    }
}
