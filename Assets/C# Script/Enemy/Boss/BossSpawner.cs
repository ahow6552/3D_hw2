using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public GameObject Boss;
    public Vector3 BossPos;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Boss, BossPos, Quaternion.identity);
        Destroy(gameObject, 0.5f);
    }
}
