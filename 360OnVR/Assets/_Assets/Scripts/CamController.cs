using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {
    public float rotateSpeed = 50f;
    public float limit_top = 70f;
    public float limit_donw = 70f;

    public bool up = false;
    public bool down = false;
    public bool left = false;
    public bool right = false;
    


    void start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.eulerAngles.x <= 70)
            {
                rotateItem(new Vector3(1, 0, 0), rotateSpeed);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.eulerAngles.x >= -70)
            {
                rotateItem(-new Vector3(1, 0, 0), rotateSpeed);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotateItem(Vector3.up, -rotateSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotateItem(Vector3.up, rotateSpeed);
        }
            
    }

    public void rotateItem(Vector3 direction, float speed)
    {
        transform.Rotate(direction, rotateSpeed * Time.deltaTime);
    }
}
