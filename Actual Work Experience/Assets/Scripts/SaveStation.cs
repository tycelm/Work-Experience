using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveStation : MonoBehaviour
{
    public int level;
    [SerializeField] private Image customImage;
    [SerializeField] private Image savedImage;

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
                    savedImage.enabled = true;
                    Invoke("Remove", 1);

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
                    savedImage.enabled = true;
                    Invoke("Remove", 1);

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
            savedImage.enabled = false;
        }
}
