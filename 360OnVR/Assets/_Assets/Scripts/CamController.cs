using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {
    public float rotateSpeed = 50f;
    public float limit_top = 70f;
    public float limit_donw = 70f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotateItem(-new Vector3(1, 0, 0), rotateSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rotateItem(new Vector3(1, 0, 0), rotateSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotateItem(new Vector3(0, 1, 0), -rotateSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotateItem(new Vector3(0, 1, 0), rotateSpeed);
        }  
    }

    public void rotateItem(Vector3 direction, float speed)
    {
        transform.Rotate(direction, speed * Time.deltaTime);
    }
}
