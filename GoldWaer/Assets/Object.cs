using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject Position;

    private bool beinghooked=false;

    // Update is called once per frame
    void Update()
    {
        if (beinghooked) 
        {
            gameObject.transform.position = Position.transform.position;
            gameObject.transform.rotation = Position.transform.rotation;
        }
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Gouzi")) 
        {
            beinghooked= true;
        }
          
    }
}
