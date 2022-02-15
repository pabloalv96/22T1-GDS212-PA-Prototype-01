using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool impacted = false;
    public Transform initialPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Car1" || other.gameObject.tag == "Car2")
        {
            Debug.Log("Collided");
            //Destroy(gameObject);
            impacted = true;
        }
    }
}
