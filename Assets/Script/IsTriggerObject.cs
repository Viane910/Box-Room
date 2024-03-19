using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IsTriggerObject : MonoBehaviour
{
    public GameObject[] objectsToEnableDisable;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject obj in objectsToEnableDisable)
            {
                obj.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject obj in objectsToEnableDisable)
            {
                obj.SetActive(false);
            }
        }
    }
}
