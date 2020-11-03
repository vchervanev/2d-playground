using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    [SerializeField] private GameObject bulletPrefab;

    public float angleSpeed = 1;
    private float angle = 1.5f;
    private Vector3 orientation;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dy = Input.GetAxis("Vertical");
        float dx = Input.GetAxis("Horizontal");
        angle -= dx * Time.deltaTime * angleSpeed;
        orientation.x = Mathf.Cos(angle);
        orientation.y = Mathf.Sin(angle);
        orientation.Normalize();
        transform.rotation = Quaternion.Euler(0, 0, angle*180/Mathf.PI - 90);
        transform.position += orientation * dy * Time.deltaTime * speed;

        if (Input.GetButtonDown("Fire1")) {
            Vector3 start = transform.position + 0.1f * orientation;
            Debug.Log("start " + start.ToString("F4"));
            GameObject bullet = Instantiate(bulletPrefab) as GameObject;
            bullet.transform.position = start;
            bullet.transform.rotation = Quaternion.Euler(0, 0, angle*180/Mathf.PI - 135);
            bullet.GetComponent<Rigidbody2D>().velocity = orientation * 15f;
        }
    }
}
