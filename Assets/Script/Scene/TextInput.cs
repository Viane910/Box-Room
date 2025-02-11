using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    public GameObject popupPanel;
    public InputField inputField;
    public string[] keyword; // Keyword to open the pop-up

    // Called when another collider enters the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the collider is triggered by the player
        {
            OpenPopup();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the collider is triggered by the player
        {
            ClosePopup();
        }
    }

    // Call this function to check if input text is correct
    public void CheckInputText()
    {
        if (keyword.Contains(inputField.text))
        {
            SceneManager.LoadScene("FinalScene");
            ClosePopup();
            Time.timeScale = 1;
        }
        else
        {
            ClosePopup();
            Time.timeScale = 1;
            Debug.Log("Incorrect input. Try again.");
        }
    }

    // Open the pop-up window
    void OpenPopup()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(true);
        }
    }

    // Close the pop-up window
    void ClosePopup()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(false);
        }
    }
}
