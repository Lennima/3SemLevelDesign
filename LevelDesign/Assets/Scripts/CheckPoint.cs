using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Transform spawnPoint;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("ReachedCheckpoint");
            CheckPointManager.SetSpawn(spawnPoint);
            Destroy(this);
        }
        
    }
}
