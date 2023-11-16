using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon : MonoBehaviour
{
    public int Maxhp;
    private int curhp;
    public GameObject Itself;
    public int RewardScore;

    void Start()
    {
        curhp = Maxhp;
    }

    void Update()
    {
        if (curhp <= 0)
        {
            Destroy(Itself.gameObject);
            GameObject.Find("Player").GetComponent<Player>().AddScore(RewardScore);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "PlayerBullet")
        {
            curhp--;
            Debug.Log("enemy's hp:" + curhp);
        }
    }

    public void BeHealth()
    {
        if (curhp < Maxhp)
        {
            curhp++;
        }
    }
}
