using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMechanic : MonoBehaviour
{
    //Si souris est sur gameObject et clic gauche : print nom gameobject

    // Start is called before the first frame update

    public bool isGrowing = false;
    public bool isShrinking = false;

    void Start()
    {

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
