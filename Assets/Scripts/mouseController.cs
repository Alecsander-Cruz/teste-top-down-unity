using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseController : MonoBehaviour
{
    Vector3 mousePoint;
    Rigidbody2D rb;
    Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        rotateCamera();
    }

    void rotateCamera()
    {
        mousePoint = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, (Input.mousePosition.z - camera.transform.position.z)));
        rb.transform.eulerAngles = new Vector3(0,0, Mathf.Atan2((mousePoint.y - transform.position.y), (mousePoint.x - transform.position.x)) * Mathf.Rad2Deg);
    }
}
