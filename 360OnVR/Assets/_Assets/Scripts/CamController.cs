using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField] private Transform pivot;
    [SerializeField] private Transform Cam;
    public float rotateSpeed = 50f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotateItem(pivot, -new Vector3(1, 0, 0), rotateSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rotateItem(pivot, new Vector3(1, 0, 0), rotateSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotateItem(Cam, new Vector3(0, 1, 0), -rotateSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotateItem(Cam, new Vector3(0, 1, 0), rotateSpeed);
        }
    }

    public void rotateItem(Transform root, Vector3 direction, float speed)
    {
        root.Rotate(direction, speed * Time.deltaTime);
    }
}