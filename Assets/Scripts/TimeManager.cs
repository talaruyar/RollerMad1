using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMNgerTimeManager : MonoBehaviour
{
    [SerializeField] private float levelFinishTime = 5f;
    private bool gameFinished = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= levelFinishTime)
        {
            print(Time.time);
            gameFinished = true;
            print("Oyun bitti");
        }
    }
}
