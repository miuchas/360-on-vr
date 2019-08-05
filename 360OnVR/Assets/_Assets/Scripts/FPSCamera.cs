using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Assets.Scripts
{
    public class FPSCamera : MonoBehaviour
    {
        public float rotationSpeed = 50f;
        float minimunX = -360f, maximunX = 360f, minimunY = -60f, maximunY = 60f;
        float sensitiveX = 15f, sensitiveY = 15f;
        float rotationX, rotationY;

        public Camera cam;

        private void Update()
        {
            MoveCamera();
        }

        void MoveCamera()
        {
            if (Input.GetMouseButtonDown(0))
            {
                rotationX += Input.GetAxis("Mouse X") * sensitiveX * rotationSpeed * Time.deltaTime;
                rotationY += Input.GetAxis("Mouse Y") * sensitiveY * rotationSpeed * Time.deltaTime;

                rotationX = Mathf.Clamp(rotationX, minimunX, maximunX);
                rotationY = Mathf.Clamp(rotationY, minimunY, maximunY);

                cam.transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
            }
        }
    }
}
