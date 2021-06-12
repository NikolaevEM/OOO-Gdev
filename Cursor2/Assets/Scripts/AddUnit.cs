using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddUnit : MonoBehaviour
{
    public GameObject unitPrefab;
    public float respawnTime = 1.0f;
    Vector3 mousePos;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Updatew());

    }
    private void spawnUnit()
    {
        GameObject a = Instantiate(unitPrefab) as GameObject;
        mousePos = Input.mousePosition;
        a.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
    }

    // Update is called once per frame
    IEnumerator Updatew()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            if (Input.GetMouseButton(1))
            {
                spawnUnit();
            }
        }
    }
}
