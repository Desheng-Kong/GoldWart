using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // set the boolean variable for triggering the time.
    public bool timesUp = false;
    // link the swing scipts method.
    public Swing swing; 
    // drag in 
    [SerializeField] GameObject loseMenu;
    // drag in
    [SerializeField] GameObject winMenu;
    // drag in
    [SerializeField] TMP_Text TimeDisplay;
    // drag in
    [SerializeField] TMP_Text GoalDisplay;
    // drag in
    [SerializeField] TMP_Text MoneyDisplay;
    // set the amount of time of the level.
    [SerializeField] float time;
    // set the moneyGoal of the level.
    public float MoneyGoal;

    private void Start()
    {
        // to ensure that the lose menu is disable while the game start.
        loseMenu.SetActive(false);
    }
 
    void Update()
    {
        // if the time is smaller than zero
        if (time <= 0)
        {
            // set the time to equal zero.
            time = 0;
            // enable the losing menu.
            if (swing.price >= MoneyGoal)
            {
                winMenu.SetActive(true);
            }
            else 
            {
                loseMenu.SetActive(true);
            }
            
            // 
            Debug.Log("timesUp");
        }
        else
        {   
            // running the time.
            time -= Time.deltaTime;
        }
        
        // set a variable take place of the swing scripts variable.
        string Money_Display =swing.price.ToString();
        string time_display = time.ToString("0.00");
        string Money_Goal = MoneyGoal.ToString();

        // set the UI to be equal to the varibale being transfered.
        TimeDisplay.text = time_display;
        GoalDisplay.text = Money_Goal; 
        MoneyDisplay.text = Money_Display;

        // the losing pausing winning metho support.
        stopEverthing();
    }

    // Method use to freze the whole game.
    // while either any of the menu is enable. 
    void stopEverthing()
    {
        if (winMenu.activeSelf || loseMenu.activeSelf )
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

}
    