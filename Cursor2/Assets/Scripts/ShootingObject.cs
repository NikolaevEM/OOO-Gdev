using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingObject : MonoBehaviour
{
    // Актуальный скрипт спавна ammo по направлению по КД

    public float offset;

    public GameObject ammo;
    public Transform shotDir;

    private float timeShot;
    public float startTime;

    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

        if (timeShot <= 0)
        {
            Instantiate(ammo, shotDir.position, transform.rotation);
            timeShot = startTime;
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
    }
}
