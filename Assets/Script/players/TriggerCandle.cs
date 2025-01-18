using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCandle : MonoBehaviour
{
    public GameObject[] objectsToEnableDisable;
    private bool isPaused = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject obj in objectsToEnableDisable)
            {
                obj.SetActive(true);
                Time.timeScale = 0f;
                isPaused = true;
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
                isPaused = false;
            }
        }
    }
}
