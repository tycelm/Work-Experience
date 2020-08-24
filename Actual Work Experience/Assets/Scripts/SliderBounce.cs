using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderBounce : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool goingRight = true;

    public Transform edgeDetection;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D edgeInfo = Physics2D.Raycast(edgeDetection.position, Vector2.down, distance);
        if(edgeInfo.collider == false)
        {
            if(goingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                goingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, -0, 0);
                goingRight = true;
            }
        }
    }
}
