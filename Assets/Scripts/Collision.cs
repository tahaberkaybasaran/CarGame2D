using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    Boolean isPickedUp;
    [SerializeField] float pickingDelayTime = 0.5f;

    [SerializeField] Color32 pickedUpColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 deliveredColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRendererCar;

    void Start()
    {
        spriteRendererCar = GetComponent<SpriteRenderer>();
    }



    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Car Crash!!!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Customer" && !isPickedUp)
        {
            Debug.Log("The package picked up!");
            isPickedUp = true;
            spriteRendererCar.color = pickedUpColor;
            Destroy(other.gameObject, pickingDelayTime);
        }
        else if (other.tag == "FinishPoint" && isPickedUp)
        {
            Debug.Log("The package is delivered!");
            isPickedUp = false;
            spriteRendererCar.color = deliveredColor;
        }

    }
}
