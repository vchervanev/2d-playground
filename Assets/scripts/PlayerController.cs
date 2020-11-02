using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    [SerializeField] private GameObject bulletPrefab;
    private Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position - Vector3.up;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dy = Input.GetAxis("Vertical");
        float dx = Input.GetAxis("Horizontal");
        transform.position += new Vector3(dx, dy, 0) * Time.deltaTime * speed;

        if (Input.GetButtonDown("Fire1")) {
            Vector3 direction = (transform.position - lastPosition);
            Debug.Log("Position " + transform.position.ToString("F4"));
            Debug.Log("LastPosition " + lastPosition.ToString("F4"));
            Debug.Log(direction.ToString("F4"));
            direction.Normalize();
            Debug.Log(direction.ToString("F4"));

            Vector3 start = transform.position + 5 * direction;
            Debug.Log("start " + start.ToString("F4"));
            GameObject bullet = Instantiate(bulletPrefab) as GameObject;
            bullet.transform.position = start;
            bullet.GetComponent<Rigidbody2D>().velocity = direction * 0.5f;
        }
        if (Vector3.Distance(lastPosition, transform.position) > 0.1) {
            lastPosition = transform.position;
        }
    }
}
