using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touched : MonoBehaviour
{
    // Start is called before the first frame update

    public bool shouHuiLai=false;
    int timesHit = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timesHit == 2)
        {
            shouHuiLai = true;
            timesHit = 0;
        }
        else 
        {
            shouHuiLai = false;
        }


      

        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null) 
        {
            if (collision.tag == "Gouzi") 
            {
                timesHit += 1;
            }
        }

        Debug.Log(timesHit);

    }
}
