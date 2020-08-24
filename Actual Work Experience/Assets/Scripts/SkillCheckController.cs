using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCheckController : MonoBehaviour
{
    public GameObject SliderImage; 
    public GameObject EndPointImage; 
    public GameObject Camera;
    public GameObject player;
    public bool passed;
    public bool gotValue;
    private CharacterController2D myPlayer;

    Vector3 point;
    float goalLocation;
    float Slider;
    float EndPoint;
    bool onIt;
    // Start is called before the first frame update


    void OnEnable()
    {
        point = transform.position;
        EndPoint = EndPointImage.transform.position.x;
        Slider = SliderImage.transform.position.x;

        goalLocation = Random.Range(Slider, EndPoint);
        point.x = goalLocation;
        transform.position = point;
        myPlayer = player.GetComponent<CharacterController2D>();

        myPlayer.canMove = false;
        Debug.Log("Ran");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Crouch"))
        {
            if(onIt)
            {
                onIt = false;
                gotValue = true;
                passed = true;
                Debug.Log("Passed");
            }
            else
            {
                gotValue = true;
                passed = false;
                Debug.Log("Failed");
            }

            Camera.SetActive(false);
            myPlayer.canMove = true;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
        {
            if(col.CompareTag("Enemy"))
            {
                onIt = true;
            }
        }

        void OnTriggerStay2D(Collider2D col)
        {
            if(col.CompareTag("Enemy"))
            {
                onIt = true;
            }
        }

        void OnTriggerExit2D(Collider2D col)
        {
            if(col.CompareTag("Enemy"))
            {
                onIt = false;
            }
        }
}
