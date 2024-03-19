using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameScript : MonoBehaviour
{
    public GameObject storyPopup;

    // Start is called before the first frame update
    void Start()
    {
        storyPopup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TogglePopup()
    {
        storyPopup.SetActive(!storyPopup.activeSelf);
    }
}
