using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject Magma;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0, -0.1f ,0));
        if (this.transform.position.y <= 0.1f)
        {
            Instantiate(Magma, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
