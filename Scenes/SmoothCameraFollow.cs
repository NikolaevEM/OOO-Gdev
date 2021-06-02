using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{

    //The speed of the movement
    public float cameraSpeed = 0.9f;
    public float speedofIncrease = 1;

    //Min and max-values the camera can move to.
    private float MAX_X = 60;
    private float MIN_X = -60;
    private float MAX_Y = 30;
    private float MIN_Y = -30;


    //The current x and y movement of the cursor
    private float Xmouse;
    private float Ymouse;

    //Variables for zoom

    public bool ispressed = false;


    void Start()
    {

    }

    void Update()
    {

        //THE ZOOM
      
        //END OF ZOOM

        Xmouse = Input.GetAxis("Mouse X");
        Ymouse = Input.GetAxis("Mouse Y");

        Vector3 v3 = Input.mousePosition;
        v3.z = transform.position.z;
        v3 = Camera.main.ScreenToWorldPoint(v3);

        Vector3 newPos = transform.position;
        newPos.x += Xmouse * speedofIncrease;
        newPos.y += Ymouse * speedofIncrease;
        newPos.z = -1;

        if (newPos.x > MAX_X)
        {
            newPos.x = MAX_X;
            newPos.z = -1;
        }
        if (newPos.x < MIN_X)
        {
            newPos.x = MIN_X;
            newPos.z = -1;
        }

        if (newPos.y > MAX_Y)
        {
            newPos.y = MAX_Y;
            newPos.z = -1;
        }
        if (newPos.y < MIN_Y)
        {
            newPos.y = MIN_Y;
            newPos.z = -1;
        }

        transform.position = Vector3.Lerp(transform.position, newPos, cameraSpeed * Time.deltaTime);
        
    }

}