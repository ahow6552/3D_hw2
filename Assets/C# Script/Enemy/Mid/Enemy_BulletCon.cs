using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_BulletCon : MonoBehaviour
{
    public float speed = 0.3f;
    Vector3 Target = Vector3.zero;
    private GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
        if (Player != null)
        {
            Target = Player.transform.position - this.transform.position;
            Target = Target.normalized * speed;
            Destroy(this.gameObject, 4);
        }
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Target);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
            GameObject.Find("Player").GetComponent<Player>().getHurt();
        }
    }
}
