using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public string key2;
    public string key;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            CameraOne();
        }

        if (Input.GetKeyDown(key2))
        {
            CameraTwo();
        }
    }
    void CameraOne()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
    }

    void CameraTwo()
    {
        camera2.SetActive(true);
        camera1.SetActive(false);
    }
}
