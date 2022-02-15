using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float currentTime;
    public float startingTime = 10f;

    [SerializeField] Text countdownText;
    public bool activeTimer = true;

    void Start()
    {
        //activeTimer = true;
        currentTime = startingTime;
    }
    void Update()
    {
        if (activeTimer)
        {
            countdownText.text = currentTime.ToString("0");
            currentTime -= 1 * Time.deltaTime;
            
            if (currentTime <= 0)
            {
                currentTime = 0;
                // Your Code Here
                activeTimer = false;
            }
        }
        
    }
}
