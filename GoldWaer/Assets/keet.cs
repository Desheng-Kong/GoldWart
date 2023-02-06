using Unity.VisualScripting;
using UnityEngine;

public class keet : MonoBehaviour
{

    [SerializeField] Swing swing;

    private GameObject itemDelate;

    public GameObject us;

    public bool hit;


    // Update is called once per frame
    void Update()
    {
        // to stick the hook to the Waer.
        // put those two gameobject together.
   
        transform.position = us.transform.position;
        transform.rotation = us.transform.rotation;

        if (swing.transform.localScale==swing.defalutScale) 
        {
            swing.catched=false;
            Destroy(itemDelate);
        }


        /*To prevent the hook would not drag two objects at a time.
        if (swing.catched)
        {
            GetComponent<BoxCollider2D>().enabled= false;
        }
        else 
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
        */

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // to see if the hook is time to swing back.

        // if the the object not hit with the wall for swing.
        // then let the varibale of the catched to be true.
        if(collision.transform.tag!=null)
            swing.catched = true;

        switch (collision.transform.tag) 
        {
            case "Object":
                // if the hook hooked something.
                // set the speed of the animation bit slower.

                itemDelate = collision.gameObject;
                passTheValue(collision.gameObject);

                break;

            default:       
                hit =!hit; 
                break;
        }   
    }


    public void passTheValue(GameObject gameObject) 
    {
        swing.speed = gameObject.GetComponent<Object>().speed;
        swing.price = gameObject.GetComponent<Object>().price;
    }
}
