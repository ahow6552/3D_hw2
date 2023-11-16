using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float CoolDown = 1f;
    public int hp = 30;
    public int curScore;
    public GameObject GG;

    void Update()
    {
        if (hp <= 0)
        {
            GG.SetActive(true);
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }

    public void AddScore(int Score)
    {
        curScore += Score;
        Debug.Log("Score: " + curScore);
    }

    public void getHurt()
    {
        hp--;
        Debug.Log("GetHurt, hp = " +  hp);
    }

    public void Fall()
    {
        hp = 0;
        Debug.Log("Fall and Die");
    }

    public void Health()
    {
        hp += 5;
    }
}
