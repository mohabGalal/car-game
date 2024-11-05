using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc2 : MonoBehaviour
{
    public float speed = 25f;
    public Vector3 Pos;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
