using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public string sceneToGameOver = "GameOver";
    Image timerBar;
    public float gameTime = 60f;
    float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / gameTime;
        }
        else
        {
            SceneManager.LoadScene(sceneToGameOver);
        }
    }
    //public void Switch(int _scene)
    //{
    //    SceneManager.LoadScene(_scene);
    //}
}
