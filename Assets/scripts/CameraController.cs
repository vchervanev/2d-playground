using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject target;
    private Vector3 offset;
    public int threshold;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
        // Vector3 delta = transform.position - target.transform.position;
        // if (Mathf.Abs(delta.x) > threshold || Mathf.Abs(delta.y) > threshold)
        // {
            // Vector3 newDelta = target.transform.position + offset - transform.position;
            // if (newDelta.x > threshold)
            // {
            //     newDelta.x -= threshold;
            // }
            // if (newDelta.x < -threshold)
            // {
            //     newDelta.x += threshold;
            // }
            // if (newDelta.y > threshold)
            // {
            //     newDelta.y -= threshold;
            // }
            // if (newDelta.y < -threshold)
            // {
            //     newDelta.y += threshold;
            // }
        // }
    }
}
