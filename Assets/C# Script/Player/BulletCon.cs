using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCon : MonoBehaviour
{
    public float speed = 1;
    Vector3 dir = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0, speed, 0));
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }


}
