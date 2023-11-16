using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialEnemySpawner : MonoBehaviour
{
    public GameObject[] Enemy;
    // Update is called once per frame
    void Start()
    {
        int rand = Random.Range(0, 3);
        Destroy(this.gameObject);
        Instantiate(Enemy[rand], this.transform.position, Quaternion.identity);
    }
}
