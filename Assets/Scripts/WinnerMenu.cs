using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerMenu : MonoBehaviour
{

    public GameObject winner;
    public GameObject winnerPanel;

    public GameObject timerGO;

    [SerializeField]
    private Timer timer;

    public AudioClip winClip;
    public AudioSource audio;

    public bool hasWinSoundPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(winner.GetComponent<Winner>().winner)
        {
            winnerPanel.SetActive(true);
            Time.timeScale = 0f;
            timer.activeTimer = false;
            
            
            if(!hasWinSoundPlayed)
            {
                hasWinSoundPlayed = true;
                audio.PlayOneShot(winClip);
            }
        } 

        
    }
}
