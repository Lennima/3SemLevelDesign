using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] public TMP_Text collectableAmount;
    [SerializeField] public Transform respawnPoint;
    public int amountOfCollectables = 0;

    private CharacterController controller;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
	  CheckPointManager.SetSpawn(respawnPoint);
    }
    void Update()
    {
        collectableAmount.text = amountOfCollectables.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectable")
        {
            amountOfCollectables++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Death")
        {
            controller.enabled = false;
            gameObject.transform.position = CheckPointManager.GetSpawn().position;
            controller.enabled = true;
        }
    }
}
