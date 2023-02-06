using UnityEngine;

[CreateAssetMenu(fileName = "New_Object", menuName = "Items", order = 1)] 
public class Items :ScriptableObject
{
    public float speed;

    public float price;

    public object_Kinds type;

    public Vector3 scale = new Vector3(1, 1, 0);

}


public enum object_Kinds 
{
    Stone,

    Gold
}



