using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Swing : MonoBehaviour 
{ 

    public bool no =false;

    public bool Going = false;

    public bool catched = false;

    public Vector3 defalutScale;

    public Vector3 Hook;

    [SerializeField] Animator animator;

    public keet keet;

    private float time;

    private void Start()
    {
        defalutScale= transform.localScale;
        Hook = new Vector3(defalutScale.x, 5.5f);
    }

    void Update()
    {
        no = keet.hit;
        if (catched) 
        {
            if (transform.localScale.y > 0.5 && transform.localScale.y < 0.6f)
            {
                transform.localScale = defalutScale;

                Debug.Log("rubf");
                Going = false;
            }
        }
       

        if (!no && !Going)
        {
            transform.Rotate(0, 0, .2f);
        }
        else if (no && !Going)
        {
            transform.Rotate(0, 0, -.2f);
        }
        else if(Going)
        {
            transform.Rotate(0, 0, 0);

            if (!catched)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, Hook, 3 * Time.deltaTime);
            }
            else 
            {
                transform.localScale = Vector3.Lerp(transform.localScale, defalutScale, 5 * Time.deltaTime);
            }
           
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Going = !Going;
        }
       
    }


}
