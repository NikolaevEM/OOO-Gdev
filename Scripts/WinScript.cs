using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public int Dest = 0;

    public void Schetchik()
    {
        Dest++;
    }

    // Update is called once per frame
    void Update()
    {
        if(Dest == 5)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
