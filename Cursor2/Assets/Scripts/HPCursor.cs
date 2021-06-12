using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPCursor : MonoBehaviour
{
    // Актуальный скрипт

    public int health;
    public static int numberOfLives;

    public Image[] lives;

    public Sprite HP1;
    public Sprite HP0;

    void Start()
    {

    }

    void Update()
    {

        if (health > numberOfLives)
        {
            health = numberOfLives;
        }
        if (numberOfLives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        for (int i = 0; i < lives.Length; i++)
        {
            if (i < health)
            {
                lives[i].sprite = HP0;
            }
            else
            {
                lives[i].sprite = HP1;
            }

            if (i < numberOfLives)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }
    }
}

