using UnityEngine;

public class Swing : MonoBehaviour 
{ 
    // the variable to see if the hook hits the wall or not
    public bool no =false;
    // the variable to see if the hook is now using or not
    public bool Going = false;
    // the variable to see if the hook hooked anything or not
    public bool catched = false;
    // set the defalut scale of the IK of the hook.
    public Vector3 defalutScale;
    // set the longth of the hool when used.
    public Vector3 Hook;
    // set the speed of the IK.
    public float speed;
    // set the price that from the object
    public float price;
    // a entry of the hook script.
    public keet keet;

    private void Start()
    {
        speed = 3f;
        defalutScale= transform.localScale;
        Hook = new Vector3(defalutScale.x, 5.5f);
    }

    void Update()
    {
        // assign the value from the hook's script/
        no = keet.hit;
        // if the hook hooked anything

       
        if (catched)
        {
            if (Input.GetKeyDown(KeyCode.W)) 
            {
                // let if back to normal state instead of waiting.
                transform.localScale = defalutScale;

                // reset the speed of the IK back to normal.
                speed = 3.0f;

                // set the hook using variable back to false.
                Going = false;
            }

            // if the hook is about to back to the normal scale/postion.
            if (transform.localScale.y > 0.5 && transform.localScale.y < 0.6f)
            {
                // let if back to normal state instead of waiting.
                transform.localScale = defalutScale;

                // reset the speed of the IK back to normal.
                speed = 3.0f;

                // set the hook using variable back to false.
                Going = false;

            }
        }
  
        // if the hook is currently NOT USING
        if (!Going) 
        {
            // the variable that let the IK of the hook to swing side to side.
            if (!no)
            {
                transform.Rotate(0, 0, .2f);
            }
            else if (no)
            {
                transform.Rotate(0, 0, -.2f);
            }

            // whenever player press the key "space" 
            // set the Going varibale to be oppsite, usually would be true

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Going = true;
            }
        }
        // if the hook is currently USING.
        // throw the hook by method below.
        else if(Going)
        {
            // stop the swing by stop the IK's rotation.
            transform.Rotate(0, 0, 0);

            // if the hook haven't catch anything during the time.
            if (!catched)
            {
                // keep pull out the hook till it hits the boundary OR reach it's max length.
                transform.localScale = Vector3.Lerp(transform.localScale, Hook, speed * Time.deltaTime);
            }
            // if the hook hooked anything duringn the pulling.
            else if(catched) 
            {
                if (speed == 3f) 
                {
                    speed = 5.0f;
                }

                // drag back the hook by scale IK's lenth to normal state. 
                transform.localScale = Vector3.Lerp(transform.localScale, defalutScale, speed * Time.deltaTime);

            }
        }

        
    }

    public void _hook(float speed) 
    {

    } 

}
