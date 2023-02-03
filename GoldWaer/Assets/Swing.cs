using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Swing : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame

    public bool no =false;

    bool Going = false;

    Vector3 back;

    [SerializeField] GameObject gz;

    [SerializeField] Animator animator;

    public keet keet;

    public touched touch;

    private void Start()
    {
        back = gz.transform.position;
    }
    void Update()
    {
        no = keet.hit;


        if (transform.localScale.y == 0.5)
        {
            Debug.Log("normal");
        }


        if (!no && !Going)
        {
            transform.Rotate(0, 0, .2f);
            animator.SetBool("meets", false);
        }
        else if (no && !Going)
        {
            transform.Rotate(0, 0, -.2f);
            animator.SetBool("meets", false);
        }
        else if(Going)
        {
            
            transform.Rotate(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Going = !Going;
            animator.SetBool("meets", true);
        }

        /*
        if (touch.shouHuiLai)
        {
            transform.Rotate(0, 0, 0);
            Going = !Going;
        }
        */




    }

}
