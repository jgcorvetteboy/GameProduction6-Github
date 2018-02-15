using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour {

	public GameObject nextCheckpointTrigger;
    public GameObject lastCheckpointTrigger;

    void OnTriggerEnter(Collider other) // disables current checkpoint and enables next checkpoint when player passes
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nextCheckpointTrigger.SetActive(true);
            lastCheckpointTrigger.SetActive(false);
        }
    }
}
