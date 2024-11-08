using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Obj;
    public float fireRate;

    void Start()
    {
        InvokeRepeating("LOL", 0, fireRate);
    }

    void LOL()
    {
        Instantiate(Obj, transform.position, transform.rotation);
    }
}
