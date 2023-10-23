using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float carRotateSpeed = 300.0f;
    [SerializeField] float carTransformSpeed = 20.0f;
    [SerializeField] float boostSpeed = 40.0f;
    [SerializeField] float slowSpeed = 10.0f;
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

    // void OnCollisionEnter2D(Collision2D other)
    // {
    //     carTransformSpeed = slowSpeed;
    // }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SpeedBoost")
        {
            carTransformSpeed = boostSpeed;
        }

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "SpeedDown")
        {
            carTransformSpeed = slowSpeed;
        }
    }
}
