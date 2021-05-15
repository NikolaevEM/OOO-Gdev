using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrag : MonoBehaviour
{
    public float dragSpeed = 2;
    private Vector3 dragOrigin;

    public Vector2 maxXPositions, maxYPositions;


    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            dragOrigin = Input.mousePosition;
            return;
        }
 
        if (!Input.GetMouseButton(2)) return;
 
        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
       // Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed,0);
        Vector3 move = new Vector3(Mathf.Clamp(pos.x * dragSpeed, maxXPositions.x, maxXPositions.y), Mathf.Clamp(pos.y * dragSpeed, maxYPositions.x, maxYPositions.y), 0);
        //Vector3 targetPosition = new Vector3(Mathf.Clamp(pos.x * dragSpeed, maxXPositions.x, maxXPositions.y), Mathf.Clamp(pos.y * dragSpeed, maxYPositions.x, maxYPositions.y), 0);

        transform.Translate(move, Space.World);

        //transform.position = Vector3.Lerp(pos, targetPosition, Time.deltaTime * speed);

    }
 
 
}
