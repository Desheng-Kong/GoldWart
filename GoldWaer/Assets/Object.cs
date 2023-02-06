using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField] GameObject Position;

    private bool beinghooked=false;

    public Items items;

    public Swing swing;

    //

    public int type;

    public float speed;

    public float price;

    public Vector3 scale;


    //

    private void Start()
    {
        
    }

    void Update()
    {
        if (beinghooked) 
        {
            gameObject.transform.position = Position.transform.position;
            gameObject.transform.rotation = Position.transform.rotation;
        }

        //Debug.Log(items.scale);

        Speed(items);
        Price(items);
        Scale(items);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Gouzi")) 
        {
            beinghooked= true;
        }
    }

    public void Speed(Items items) 
    {
        speed=items.speed;
    }

    public void Price(Items items)
    {
        price=items.price;
    }

    public void Kinds(Items items) 
    {
        type = (int)items.type;
    }

    public void Scale(Items items) 
    {
        transform.localScale = items.scale;
    }

}
