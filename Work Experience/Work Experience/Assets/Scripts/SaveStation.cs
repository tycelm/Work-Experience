using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveStation : MonoBehaviour
{
    public GameObject player;
    public Status stat;
    public CharacterController2D move;
    public GameObject saveImage;

    public int level;
    [SerializeField] private Image customImage;

    void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex;
    }

    void OnTriggerEnter2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                customImage.enabled = true;
                if(Input.GetKeyDown("space"))
                {
                    customImage.enabled = false;
                    saveImage.SetActive(true);
                    move.canMove = false;
                    Invoke("Remove", 3);
                    

                    SaveSystem.SavePlayer(this);
                }
            }
        }

        void OnTriggerStay2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                if(Input.GetKeyDown("space"))
                {
                    customImage.enabled = false;
                    saveImage.SetActive(true);
                    move.canMove = false;
                    Invoke("Remove", 3);

                    SaveSystem.SavePlayer(this);
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

        void Remove()
        {
            move.canMove = true;
            saveImage.SetActive(false);
        }
}
