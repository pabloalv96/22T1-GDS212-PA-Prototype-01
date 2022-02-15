using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicles : MonoBehaviour
{

    [SerializeField] float speed;
    //public bool impacted = false;

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Car1")
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
        if(gameObject.tag == "Car2")
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Collided");
            Destroy(other.gameObject);
            impacted = true;
        }
    }*/
}
