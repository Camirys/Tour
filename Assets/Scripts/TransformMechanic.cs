using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMechanic : MonoBehaviour
{
    //Si souris est sur gameObject et clic gauche : print nom gameobject

    // Start is called before the first frame update
    Vector3 objectScale;
    Rigidbody2D rb;
    public bool isGrowing = false;
    public bool isShrinking = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        objectScale = new Vector3(1.0f, 1.0f, 1.0f);

    }
    void OnMouseOver()
    {
        string objetHover = gameObject.name;
        //print(objetHover);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isGrowing = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            isGrowing = false;
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            isShrinking = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            isShrinking = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (isGrowing == true)
        {
            gameObject.transform.localScale += new Vector3(+0.002f, +0.002f, +0.002f);
        }

        if (isShrinking == true)
        {
            gameObject.transform.localScale += new Vector3(-0.002f, -0.002f, -0.002f);
            if (gameObject.transform.localScale == new Vector3(0f, 0f, 0f))
            {
                gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
                print("you can\'t!");
            }
        }
    }

   
}
