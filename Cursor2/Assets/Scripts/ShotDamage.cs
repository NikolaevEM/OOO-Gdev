using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using HPCursor;

public class ShotDamage : MonoBehaviour
{
    void OnMouseEnter()
    {
        //SceneManager.LoadScene("GameOver");
        GameObject cursor = GameObject.Find("Cursor");
        HPCursor HPCursor_ = cursor.GetComponent<HPCursor>();
        HPCursor_.numberOfLives--;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
