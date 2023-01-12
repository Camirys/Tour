using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneCaptePnj : MonoBehaviour
{
    private Player player;
    private PnjParle pnjParent;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
        pnjParent = transform.parent.GetComponent<PnjParle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.AjoutePnj(pnjParent);
            print(pnjParent.name + " added");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.EnlevePnj(pnjParent);
            print(pnjParent.name + " removed");
        }
    }
}
