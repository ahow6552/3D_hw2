using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_BulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    private float CoolDown = 0.5f;
    private float time = 0f;

    void Update()
    {
        time += Time.deltaTime;
        if (time > CoolDown)
        {
            Instantiate(bullet, this.transform.position, Quaternion.identity);
            time = 0f;
        }
    }
}
