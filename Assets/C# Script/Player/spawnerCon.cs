using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerCon : MonoBehaviour
{
    public GameObject bullet;
    float time = 0f;
    //public Player myplayer;
    public float CoolDown = 1f;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (time > CoolDown)
            {
                Instantiate(bullet, this.transform.position, this.transform.rotation);
                time = 0f; 
            }
        }
    }
}
