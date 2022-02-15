using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public bool gameStart = false;

    public GameObject timerGO;
    private Timer timer;

    public GameObject startPanel;
    public GameObject WinPanel;

    // Start is called before the first frame update
    void Start()
    {
        timer = timerGO.GetComponent<Timer>();
        if(!gameStart)
        {
            Time.timeScale = 0f;
            timer.activeTimer = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume ()
    {
        Time.timeScale = 1f;
        timer.activeTimer = true;
        startPanel.SetActive(false);
        gameStart = true;

    }

    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
