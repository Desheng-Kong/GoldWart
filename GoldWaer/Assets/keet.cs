using Unity.VisualScripting;
using UnityEngine;

public class keet : MonoBehaviour
{
    // script engaging
    [SerializeField] Swing swing;
    // the item that catched
    private GameObject itemDelate;
    // the postion vector use to drag the items up.
    public GameObject us;
    // a temporary storage varibale of the item's price.
    public float price = 0;
    // variable that used for swing the hook.
    public bool hit;


    // Update is called once per frame
    void Update()
    {
        // to stick the hook to the Waer.
        // put those two gameobject together.
 
        transform.position = us.transform.position;
        transform.rotation = us.transform.rotation;

        // if the hook in a noraml status.
        if (swing.transform.localScale==swing.defalutScale) 
        {
            // if the hook currently catched anything
            if(swing.catched)
                swing.okTOadd = true;
        }

        // if the add price variable = true.
        if (swing.okTOadd) 
        {
            // add the price to the UI
            swing.price += price;
            // set the hook to be empty
            swing.catched = false;
            // delete the hooked item.
            Destroy(itemDelate);
            // set the ok to add price variable to false.
            swing.okTOadd = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // to see if the hook is time to swing back.

        // if the the object not hit with the wall for swing.
        // then let the varibale of the catched to be true.        

        if (collision.collider != null) 
        {   
            // if the collider's tag not belong to the wall that using for hook to swing.
            if (collision.transform.tag != "Respawn") 
            {
                // set the cathed variable to true.
                swing.catched = true;
            }
        }

        //
        switch (collision.transform.tag) 
        {
            // if the tag of the collider = object
            case "Object":
                
                // se the item to the varibale
                itemDelate = collision.gameObject;
                // take the info from the item.
                passTheValue(collision.gameObject);
                break;

            // defalut is set to swing the hook
            default:       
                hit =!hit; 
                break;
        }   
    }

    // pasing value from the item to varibale.
    public void passTheValue(GameObject gameObject) 
    {
        swing.speed = gameObject.GetComponent<Object>().speed;
        price = gameObject.GetComponent<Object>().price;
    }
}
