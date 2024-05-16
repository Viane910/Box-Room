using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameScript : MonoBehaviour
{
    public GameObject storyPopup;
    public KeyCode popupKey = KeyCode.Q;

    // Start is called before the first frame update
    void Start()
    {
        storyPopup.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(popupKey))
        {
            TogglePopup();
        }
    }

    void TogglePopup()
    {
        if (storyPopup != null)
        {
            storyPopup.SetActive(!storyPopup.activeSelf);
        }
    }
}
