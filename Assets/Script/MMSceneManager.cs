using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMSceneManager : MonoBehaviour
{

    public GameObject creditPopup;

    public void LoadScene(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Bye");
    }

    //for Pop Up

    void Start()
    {
        creditPopup.SetActive(false);
    }

    public void TogglePopup()
    {
        creditPopup.SetActive(!creditPopup.activeSelf);
    }
}
