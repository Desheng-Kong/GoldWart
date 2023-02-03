using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keet : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject us;

    public bool hit = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = us.transform.position;
        transform.rotation = us.transform.rotation;

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("outside"))
        {
            Debug.Log("OutSide Now!");
        }
        hit= !hit;
    }
}
