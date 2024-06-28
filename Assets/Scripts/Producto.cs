using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Producto : MonoBehaviour
{

    public int precio;

    private float xRotationSpeed = 60f;
    private float yRotationSpeed = 20f;

    private void Update()
    {
        transform.Rotate(transform.up * Time.deltaTime * xRotationSpeed + transform.right * yRotationSpeed * Time.deltaTime + transform.forward / 2 * -yRotationSpeed * Time.deltaTime);
    }

}
