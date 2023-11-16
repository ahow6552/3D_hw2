using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialSpawnerManager : MonoBehaviour
{
    public GameObject Spawner;
    private float time = 0f;
    private float initCoolDown = 10;
    public float curCoolDown;
    public Vector3[] EnemyPos;
    bool Kill_Self = false;

    void Start()
    {
        curCoolDown = initCoolDown;
        int rand = Random.Range(0, EnemyPos.Length);
        Instantiate(Spawner, EnemyPos[rand], Quaternion.identity);

    }

    void Update()
    {
        time += Time.deltaTime;
        if (time >= curCoolDown)
        {
            int rand = Random.Range(0, EnemyPos.Length);
            Instantiate(Spawner, EnemyPos[rand], Quaternion.identity);
            time = 0f;

        }

        if(Kill_Self == true)
        {
            Destroy(gameObject);
        }
    }

    public void Pause()
    {
        Kill_Self = true;
    }
}
