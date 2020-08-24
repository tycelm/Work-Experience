using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SameLevelDoor : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    public bool wentIn;
    [SerializeField] private Image customImage;
    

        void OnTriggerEnter2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                customImage.enabled = true;
                if(Input.GetKeyDown("space"))
                {
                    player.transform.position = target.transform.position;
                    wentIn = true;
                }
            }
        }

        void OnTriggerStay2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                if(Input.GetKeyDown("space"))
                {
                    player.transform.position = target.transform.position;
                    wentIn = true;
                }
            }
        }

        void OnTriggerExit2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                customImage.enabled = false;
            }
        }
    
}
