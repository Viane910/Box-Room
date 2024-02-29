using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    //[SerializeField] private Text pickUpText;
    public bool popUp;
    private bool pickUpAllowed;
    public GameObject paper1;

    // Start is called before the first frame update
    void Start()
    {
        paper1.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            PickUpPaper1();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            paper1.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            paper1.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    public void PickUpPaper1()
    {
        if (pickUpAllowed == false)
        {
            paper1.transform.gameObject.SetActive(true);
            popUp = true;
        }
        else
        {
            paper1.transform.gameObject.SetActive(false);
            popUp = false;
        }
    }
}
