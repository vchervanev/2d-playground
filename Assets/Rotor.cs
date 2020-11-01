using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotor : MonoBehaviour
{
    public GameObject target;
    public float speed = 20f;
    public float selfSpeed = 120f;
    // private fload angle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        target.transform.RotateAround(target.transform.position, Vector3.forward, selfSpeed * Time.deltaTime);
        target.transform.RotateAround(transform.position, Vector3.forward, speed * Time.deltaTime);

    }
}
