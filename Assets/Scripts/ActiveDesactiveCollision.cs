using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDesactiveCollision : MonoBehaviour
{
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Target)
        {
            Target.SetActive(!Target.activeInHierarchy);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Target)
        {
            Target.SetActive(!Target.activeInHierarchy);
        }
    }
}
