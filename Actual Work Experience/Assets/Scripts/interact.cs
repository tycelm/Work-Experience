using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class interact : MonoBehaviour
{
    private DialogueDisplay DialogMsg;
    [SerializeField] private Image customImage;

    void Start()
    {
        DialogMsg = GetComponent<DialogueDisplay>();
        DialogMsg.enabled = false;
    }
    
        void OnTriggerEnter2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                customImage.enabled = true;
                if(Input.GetButtonDown("Space"))
                {
                    customImage.enabled = false;
                    DialogMsg.enabled = true;
                }
            }
        }

        void OnTriggerStay2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                if(Input.GetButtonDown("Space"))
                {
                    customImage.enabled = false;
                    DialogMsg.enabled = true;
                }
            }
        }

        void OnTriggerExit2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                customImage.enabled = false;
                DialogMsg.enabled = false;
            }
        }
}
