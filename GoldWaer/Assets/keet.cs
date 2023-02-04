using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keet : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Swing swing;

    private GameObject itemDelate;

    public GameObject us;

    public bool hit;

    public int Ob = 0;

    // Update is called once per frame
    void Update()
    {
        // to stick the hook to the Waer.
        // put those two gameobject together.

        transform.position = us.transform.position;
        transform.rotation = us.transform.rotation;

        if (!swing.Going) 
        {
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
                animator.speed = 2f;

                Debug.Log("OutSide Now!");
                break;

            case "Gold":
                // if the hook hooked something.
                // set the speed of the animation bit slower.

                itemDelate= collision.gameObject;

                animator.speed = 1f;
                Ob = 1;
                Debug.Log("see that's gold");
                break;

            default:
                hit=!hit; 
                break;

        }

        

    }

}
