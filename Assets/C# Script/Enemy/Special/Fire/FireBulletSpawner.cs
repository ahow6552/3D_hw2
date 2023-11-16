using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletSpawner : MonoBehaviour
{
    float time = 0f;
    public GameObject bullet;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 5f)
        { 
            Instantiate(bullet, this.transform.position, this.transform.rotation);
            time = 0f;
        }
    }
}
