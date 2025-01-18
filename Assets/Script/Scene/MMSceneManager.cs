using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MMSceneManager : MonoBehaviour
{
    public RectTransform creditsTransform; // RectTransform dari teks kredit
    public float scrollSpeed; // Kecepatan scroll, semakin besar semakin cepat
    private Vector2 startPosition;

    public GameObject creditPopup;
    public Button closeButton;

    public void LoadScene(string Prolog)
    {
        SceneManager.LoadScene(Prolog);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Bye");
    }

    //for Pop Up

    void Start()
    {
        startPosition = creditsTransform.anchoredPosition;
    }

    public void ShowCredit()
    {
        creditPopup.SetActive(true);
    }

    public void HideCredit()
    {
        creditPopup.SetActive(false);
    }

    void Update()
    {
        // Membaca input dari mouse scroll
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        if (scrollInput != 0)
        {
            // Menggerakkan RectTransform berdasarkan input scroll
            creditsTransform.anchoredPosition += Vector2.up * scrollInput * scrollSpeed;
        }
    }
}
