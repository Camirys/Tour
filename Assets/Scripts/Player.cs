using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // pour le mouvement
    public float vitesse = 2;
    Rigidbody rb;
    float inputX;
    //float inputY;
    Vector2 mouvement;
    public bool seRetourne = true;

    // pour la gestion des pnjs
    private PnjParle pnjActif;
    private List<PnjParle> listePnjs = new List<PnjParle>();


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        //inputY = Input.GetAxisRaw("Vertical");
        mouvement = (new Vector2(inputX, 0)).normalized * vitesse;
        rb.velocity = mouvement;
        if(seRetourne && rb.velocity.x > 0)
        {
            transform.localEulerAngles = new Vector2(1, 1);
        }
        if (seRetourne && rb.velocity.x < 0)
        {
            transform.localEulerAngles = new Vector2(-1, 1);
        }
        //On tente le saut
        /* if (Input.GetKeyDown(KeyCode.Space))
         {
             gameObject.transform.localPosition += new Vector3(0f, 2f, 0f);
             GetComponent<Rigidbody2D>().MovePosition(new Vector3(1, transform.position.y, 0 ));
         }*/
    }

    // pour les pnjs
    public void AjoutePnj(PnjParle newPnj)
    {
        if (pnjActif != null)
        {
            pnjActif.Deselect();
        }
        newPnj.Select();
        pnjActif = newPnj;
        listePnjs.Add(newPnj);
    }

    public void EnlevePnj(PnjParle PnjAEnlever)
    {
        PnjAEnlever.Deselect();
        listePnjs.Remove(PnjAEnlever);
        if(listePnjs.Count >= 1)
        {
            pnjActif = listePnjs[0];
            pnjActif.Select();
        }
        else
        {
            pnjActif = null;
        }
    }


}
