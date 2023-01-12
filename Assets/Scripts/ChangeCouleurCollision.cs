using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCouleurCollision : MonoBehaviour
{
    public Color[] Couleurs = new Color[] {new Color(0,0,0,1), new Color(1,1,1,1) };
    public bool CollideAvecTout = false;
    private int compteur = -1;

    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || CollideAvecTout)
        {
            ChangeCouleur();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || CollideAvecTout)
        {
            ChangeCouleur();
        }
    }

    void ChangeCouleur()
    {
        compteur += 1;
        if (compteur >= Couleurs.Length)
        {
            compteur = 0;
        }
        sr.color = Couleurs[compteur];
    }
}
