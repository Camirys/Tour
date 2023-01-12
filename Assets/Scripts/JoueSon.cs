using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoueSon : MonoBehaviour
{

    public AudioClip son;
    private SoundManager sm;
    public bool randomPitch = false;

    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.FindObjectOfType<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            sm.PlaySingleSound(son,0,randomPitch);     
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            sm.PlaySingleSound(son, 0, randomPitch);
        }
    }
}
