using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Image customImage;
    public GameObject door;
    public GameObject controller;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            customImage.enabled = true;
            if (Input.GetKeyDown("space"))
            {
                customImage.enabled = false;
                Invoke("transport", Random.Range(5, 10));
            }
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKeyDown("space"))
            {
                customImage.enabled = false;
                Invoke("transport", Random.Range(5, 10));
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            customImage.enabled = false;
        }
    }

    public void transport()
    {
        door.SetActive(true);
        controller.SetActive(false);
    }

}
