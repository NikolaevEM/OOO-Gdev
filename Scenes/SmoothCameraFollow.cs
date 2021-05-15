using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{

    //The speed of the movement
    public float cameraSpeed = 0.5f;
    public float speedofIncrease = 3;

    //Min and max-values the camera can move to.
    private float MAX_X = 6;
    private float MIN_X = -6;
    private float MAX_Y = 3;
    private float MIN_Y = -3;


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

        //Fångar upp mus-positionen först i pixlar sen översatt till koord denna frame/update
        Vector3 v3 = Input.mousePosition;
        v3.z = transform.position.z;
        v3 = Camera.main.ScreenToWorldPoint(v3);

        //Skapar koordinater dit kameran ska röra sig.
        Vector3 newPos = transform.position;
        newPos.x += Xmouse * speedofIncrease;
        newPos.y += Ymouse * speedofIncrease;
        newPos.z = -1;

        //Making sure that the camera doesn't exceed the min/max values it's allowed to move to!
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

        //Flyttar långsamt/linjärt med Lerp kameran mot den nya koordinaten.
        transform.position = Vector3.Lerp(transform.position, newPos, cameraSpeed * Time.deltaTime);
        
    }

}