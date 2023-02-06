using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    public bool timesUp = false;

    [SerializeField] GameObject loseMenu;

    [SerializeField] GameObject winMenu;

    [SerializeField] TMP_Text TimeDisplay;

    [SerializeField] TMP_Text GoalDisplay;

    [SerializeField] float time;

    public float MoneyGoal;

    private void Start()
    {

        loseMenu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

        if (time <= 0)
        {
            time = 0;
            loseMenu.SetActive(true);
            Debug.Log("timesUp");
        }
        else
        {
            time -= Time.deltaTime;
        }

        string time_display = time.ToString("0.00");
        string Money_Goal = MoneyGoal.ToString();
        TimeDisplay.text = time_display;
        GoalDisplay.text = Money_Goal; 
        stopEverthing();
    }

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
    