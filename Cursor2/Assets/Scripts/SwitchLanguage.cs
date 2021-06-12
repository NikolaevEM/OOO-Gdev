using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLanguage : MonoBehaviour
{
    public void Switch(int _scene)
    {
        SceneManager.LoadScene(_scene);
    }
}
