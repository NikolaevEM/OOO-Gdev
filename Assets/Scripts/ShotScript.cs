using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    public int damage = 1;
    public bool isEnemyShot = false;
    // Start is called before the first frame update
    void Start()
    {
        // timer to die
        Destroy(gameObject, 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
