using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCon : MonoBehaviour
{
    public int hp = 2;
    public GameObject Itself;

    void Update()
    {
        if (hp <= 0)
        {
            Destroy(Itself.gameObject);
            GameObject.Find("Player").GetComponent<Player>().Health();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "PlayerBullet")
        {
            hp--;
            Debug.Log("enemy's hp:" + hp);
        }
    }
}
