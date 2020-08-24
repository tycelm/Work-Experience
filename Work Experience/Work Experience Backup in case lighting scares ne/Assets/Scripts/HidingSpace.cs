using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HidingSpace : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Image customImage;
    [SerializeField] private Image exitImage;
    private int apply = 11;
    private bool within = false;
    private CharacterController2D myPlayer;
    
        void Start()
        {
            myPlayer = player.GetComponent<CharacterController2D>();
        }
    void Update()
    {
        if(within)
        {
            apply = 10;
        }
        else
        {
            apply = 11;
        }

    }
        void OnTriggerEnter2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                if(!within)
                {
                    customImage.enabled = true;
                    if(Input.GetButtonDown("Space"))
                    {
                        customImage.enabled = false;
                        player.layer = apply;
                        Debug.Log("Pressed");
                        within = true;
                        myPlayer.canMove = false;
                    }
                }
                else
                {
                    exitImage.enabled = true;
                    if(Input.GetButtonDown("Crouch"))
                    {
                        exitImage.enabled = false;
                        player.layer = apply;
                        within = false;

                    }
                }
            }
        }

        void OnTriggerStay2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                if(!within)
                {
                    customImage.enabled = true;
                    if(Input.GetButtonDown("Space"))
                    {
                        customImage.enabled = false;
                        player.layer = apply;
                        Debug.Log("Pressed");
                        within = true;
                        myPlayer.canMove = false;
                    }
                }
                else
                {
                    exitImage.enabled = true;
                    if(Input.GetButtonDown("Crouch"))
                    {
                        exitImage.enabled = false;
                        player.layer = apply;
                        within = false;
                        myPlayer.canMove = true;
                    }
                }
            }
        }

        void OnTriggerExit2D(Collider2D col)
        {
            if(!within)
                {
                    customImage.enabled = false;
                }
        }
    
}
