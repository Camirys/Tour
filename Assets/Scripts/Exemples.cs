using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemples : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }

        if (Input.GetKey(KeyCode.A))
        {

        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine("DoThingLater");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    private IEnumerator DoThingLater()
    {
        yield return new WaitForSeconds(1.5f);
       
    }
}
