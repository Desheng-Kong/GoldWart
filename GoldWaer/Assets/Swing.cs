using UnityEngine;

public class Swing : MonoBehaviour 
{ 

    public bool no =false;


    public bool Going = false;

    [SerializeField] Animator animator;

    public keet keet;

    private float time;

    void Update()
    {
        no = keet.hit;

        if (transform.localScale.y == 0.5)
        {
            time += Time.deltaTime;
            if (time >= .5) 
            {
                Going = false;
                animator.speed = 1;
                time = 0;
            }
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
       
    }


}
