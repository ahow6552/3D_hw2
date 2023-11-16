using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidEnemyMoveMent : MonoBehaviour
{
    public float speed = 0.1f;
    int rand;

    void Update()
    { 
        if (this.transform.position.z > 30.0f || this.transform.position.z < -30.0f)
        {
            this.transform.Rotate(new Vector3(0, 180, 0));
        }
        this.transform.Translate(new Vector3(0, 0, speed));
    }
}
