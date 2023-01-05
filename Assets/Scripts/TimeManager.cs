using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private float levelFinishTime = 5f;
    private bool gameFinished = false;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= levelFinishTime && gameOver == false)
        {
            print(Time.time);
            gameFinished = true;
            print("Oyun bitti");
        }
        if (gameOver == true)
        {
            print("restart");
        }
    }
}
