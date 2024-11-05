using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour
{
   public GameObject car;
   public Vector3 ofset= new Vector3(0, 7, -7);
    private void LateUpdate()
    {
        transform.position = car.transform.position+ofset;
    }
}
