using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject MainCamera;
    void Start()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void Update()
    {
        if(transform.position.y < -7.0f)
        {
            MainCamera.GetComponent<WinScript>().Schetchik();
            Destroy(this.gameObject);
        }
    }
}
