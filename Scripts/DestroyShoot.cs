using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShoot : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -7.0f)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.y > 5.0f)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.x < -10.0f)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.x > 18.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
