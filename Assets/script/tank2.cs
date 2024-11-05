using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank2 : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 2f;
    public Vector3 ofset;

    public string horizontal;
    public string vertical;

    private float horizontalInput2;
    private float verticalInput2;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = ofset;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput2 = Input.GetAxis(horizontal);
        verticalInput2 = Input.GetAxis(vertical);

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput2);
        
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput2);
    }
}
