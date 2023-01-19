using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMechanic : MonoBehaviour
{
    //Si souris est sur gameObject et clic gauche : print nom gameobject

    // Start is called before the first frame update

    public bool isGrowing = false;
    public bool isShrinking = false;
    bool isRotatingCW = false;
    bool isRotatingCCW = false;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseOver()
    {
        string objetHover = gameObject.name;
        //print(objetHover);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isGrowing = true;
        }
      

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            isShrinking = true;
        }

        if (Input.mouseScrollDelta.y > 0)
            {
                isRotatingCW = true;
                print("cw");
            }

        if (Input.mouseScrollDelta.y < 0)
            {
                isRotatingCCW = true;
            }
    }

// Update is called once per frame
void Update()
    {

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            isShrinking = false;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
         {
            isGrowing = false;
         }

        if (Input.mouseScrollDelta.y == 0)
        {
            rb.isKinematic = false;
            isRotatingCW = false;
            isRotatingCCW = false;

        }

        if (isGrowing == true)
        {
            gameObject.transform.localScale += new Vector3(+0.002f, +0.002f, +0.002f);
            print("growing");
        }

        if (isShrinking == true)
        {
            gameObject.transform.localScale += new Vector3(-0.002f, -0.002f, -0.002f);
            print("shrinking");
        }

        if(isRotatingCW == true)
        {
            rb.isKinematic = true;
            //GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3 (0f, 0f , 2f)));
            transform.eulerAngles += new Vector3(0f, 0f, -3f);
            print("rotating");
        }

        if (isRotatingCCW == true)
        {
            rb.isKinematic = true;
            //GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3 (0f, 0f , 2f)));
            transform.eulerAngles += new Vector3(0f, 0f, 3f);
            print("rotatingCCW");

        }

            if (gameObject.transform.localScale == new Vector3(0f, 0f, 0f))
        {

            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            isShrinking = false;
            isGrowing = false;
            //Destroy(gameObject);
            print("you can\'t!");
        }

        
    }

   
}
