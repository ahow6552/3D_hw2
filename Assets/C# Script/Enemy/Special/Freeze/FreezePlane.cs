using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePlane : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 10);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerMovement>().SlowDown();
        }
    }
}
