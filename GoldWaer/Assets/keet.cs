using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class keet : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Swing swing;

    private GameObject itemDelate;

    Vector3 defalutScale;

    public GameObject us;

    public bool hit;

    public int Ob = 0;

    private void Start()
    {
       defalutScale=swing.transform.localScale; 
    }

    // Update is called once per frame
    void Update()
    {
        // to stick the hook to the Waer.
        // put those two gameobject together.
        //Debug.Log(currentScale);


        transform.position = us.transform.position;
        transform.rotation = us.transform.rotation;

        if (swing.transform.localScale==defalutScale) 
        {
            swing.catched=false;
            Destroy(itemDelate);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // to see if the hook is time to swing back.

        switch (collision.transform.tag) 
        {
            case "outside":
                // if the hook going outside of the screen
                // set the speed of the animation back quikly.
                //animator.speed = 2f;
                catchGold(5f);
                Debug.Log("OutSide Now!");
                break;

            case "Gold":
                // if the hook hooked something.
                // set the speed of the animation bit slower.

                swing.catched = true;
                itemDelate = collision.gameObject;
                
                Ob = 1;
                Debug.Log("see that's gold");
                break;

            default:
                hit=!hit; 
                break;

        }
       
    }

    public void catchGold(float speed) 
    {
        swing.catched = true;

        //swing.transform.localScale = Vector3.Lerp(swing.transform.localScale,defalutScale,speed*Time.deltaTime);
    }

}
