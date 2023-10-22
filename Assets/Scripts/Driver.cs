using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float carRotateSpeed = 300.0f;
    [SerializeField] float carTransformSpeed = 20.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float carRotateSpeedAmount = Input.GetAxis("Horizontal") * carRotateSpeed * Time.deltaTime;
        float carSpeedRotation = Input.GetAxis("Vertical") * carTransformSpeed * Time.deltaTime;
        // Debug.Log(carRotateSpeedAmount);
        transform.Rotate(0, 0, -carRotateSpeedAmount);
        transform.Translate(0, carSpeedRotation, 0);
    }
}
