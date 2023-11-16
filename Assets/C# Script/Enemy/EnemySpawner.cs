using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    // Update is called once per frame
    void Start()
    {
        Instantiate(Enemy, this.transform.position, Quaternion.identity);
        Destroy(gameObject, 1.0f);
    }
}
