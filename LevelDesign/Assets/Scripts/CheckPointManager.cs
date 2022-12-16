using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public static CheckPointManager instance;

    [SerializeField] public static Transform currentSpawnPoint;
    
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public static void SetSpawn(Transform newSpawnPoint)
    {
        currentSpawnPoint = newSpawnPoint;
    }

    public static Transform GetSpawn ()
    {
        return currentSpawnPoint;
    }

}
