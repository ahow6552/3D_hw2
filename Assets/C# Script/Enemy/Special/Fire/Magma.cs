using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magma : MonoBehaviour
{
    private float time = 0;
    void Start()
    {
        Destroy(gameObject, 5);
    }

    void OnTriggerStay(Collider other)
    {
        time += Time.deltaTime;
        if (time >= 1 && other.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<Player>().getHurt();
            time = 0;
        }
    }
}
