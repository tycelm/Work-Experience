using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HidingSpace : MonoBehaviour
{
    public GameObject player;
    public GameObject light1;
    public GameObject light3;
    [SerializeField] private Image customImage;
    [SerializeField] private Image exitImage;
    private int apply = 11;
    private bool within = false;
    private SpriteRenderer playerLook;
    private CharacterController2D myPlayer;

    void Start()
    {
        myPlayer = player.GetComponent<CharacterController2D>();
        playerLook = player.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (within)
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
        if (col.CompareTag("Player"))
        {
            if (!within)
            {
                customImage.enabled = true;
                if (Input.GetButtonDown("Space"))
                {
                    customImage.enabled = false;
                    player.layer = apply;
                    within = true;
                    myPlayer.canMove = false;
                    playerLook.enabled = false;
                    light1.SetActive(false);
                    light3.SetActive(true);
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (!within)
            {
                customImage.enabled = true;
                if (Input.GetButtonDown("Space"))
                {
                    customImage.enabled = false;
                    player.layer = apply;
                    Debug.Log("Pressed");
                    within = true;
                    myPlayer.canMove = false;
                    playerLook.enabled = false;
                    light1.SetActive(false);
                    light3.SetActive(true);
                }
            }
            else
            {
                exitImage.enabled = true;
                if (Input.GetButtonDown("Crouch"))
                {
                    exitImage.enabled = false;
                    player.layer = apply;
                    within = false;
                    myPlayer.canMove = true;
                    playerLook.enabled = true;
                    light1.SetActive(true);
                    light3.SetActive(false);
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (!within)
        {
            customImage.enabled = false;
        }
    }

}
