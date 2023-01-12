using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporteur : MonoBehaviour
{
    public bool teleporteTout = false;
    public Transform destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || teleporteTout)
        {
            if (destination)
            {
                collision.gameObject.transform.position = new Vector3(destination.position.x, destination.position.y, collision.gameObject.transform.position.z);
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || teleporteTout)
        {
            if (destination)
            {
                collision.gameObject.transform.position = new Vector3(destination.position.x, destination.position.y, collision.gameObject.transform.position.z);
            }
        }
    }

}


