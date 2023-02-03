using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporteur : MonoBehaviour
{
    public Transform Destination;
    public GameObject Player;
    public bool teleporteTout = false;
    bool aTP = false;
     /* 
     //Attempt 1
     public Transform Destination;       // Gameobject where they will be teleported to
     public string TagList = "|Player|Boss|Friendly|"; // List of all tags that can teleport*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnTriggerEnter(Collider collision)
    {
        Player.transform.position = destination.transform.position;
    }
    /*
     * 
     Attempt 1
     public void OnTriggerEnter(Collider other)
    {
        // If the tag of the colliding object is allowed to teleport
        if (TagList.Contains(string.Format("|{0}|", other.tag)))
        {
            // Update other objects position and rotation
            print("vu");
            other.transform.position = Destination.transform.position;
            other.transform.rotation = Destination.transform.rotation;
        }

    }
      */
      private void OnTriggerEnter(Collider collision)
      {
            if (aTP == false)
            {
            print("false");
                if (collision.gameObject.tag == "Player" || teleporteTout)
                {
                    
                    collision.gameObject.transform.position = new Vector3(Destination.position.x, Destination.position.y, Destination.position.z);
                    aTP = true;
                    print("true");
                    //GameObject.Find("Player").GetComponent<Transform>().position = new Vector3 (0f, 0f, );

                }
            }
      }

    private void OnTriggerExit(Collider collision)
    {
        aTP = false;
    }


    private void OnCollisionEnter(Collision collision)
       
        {
        if (aTP == false)
            print("atpfalse");
        {
            if (collision.gameObject.tag == "Player" || teleporteTout)
            {
                if (Destination)
                {
                    print("touché");
                    collision.gameObject.transform.position = new Vector3(Destination.position.x, Destination.position.y, Destination.position.z);
                    aTP = true;
                    print("atptrue");
                }
            }
        }
        }
    //collision.gameObject.transform.position.z
    private void OnCollisionExit(Collision collision)
    {
        aTP = false;
    }


}


