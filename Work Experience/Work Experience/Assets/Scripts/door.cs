using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public int LevelToLoad;
    [SerializeField] private Image customImage;
    

        void OnTriggerEnter2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                customImage.enabled = true;
                if(Input.GetButtonDown("Space"))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }

        void OnTriggerStay2D(Collider2D col)
        {
            if(col.CompareTag("Player"))
            {
                if(Input.GetButtonDown("Space"))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
