using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseMenu : MonoBehaviour
{

    public GameObject player;
    public GameObject timer;
    public GameObject loserPanel;
    public GameObject startMenu;


    public AudioClip loseClip;
    public AudioSource audio;

    [SerializeField]
    private Timer time;
    [SerializeField] private WinnerMenu winner;

    public bool hasLoseSoundPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<Player>().impacted || timer.GetComponent<Timer>().activeTimer == false 
            && startMenu.GetComponent<StartMenu>().gameStart == true && winner.winnerPanel == false)
        {
            loserPanel.SetActive(true);
            Time.timeScale = 0f;
            time.activeTimer = false;
            

            if(!hasLoseSoundPlayed)
            {
                hasLoseSoundPlayed = true;
                audio.PlayOneShot(loseClip);
            }
        }
    }
}
