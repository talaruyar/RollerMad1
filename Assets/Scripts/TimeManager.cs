using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // user interface k�t�phanesini �ekmek i�in. canvas �zeirnde i�lemler yapabilmek i�in bu laz�m


public class TimeManager : MonoBehaviour
{

    [SerializeField] private float levelFinishTime = 5f;
    private bool gameFinished = false;
    public bool gameOver = false;
    [SerializeField] private Text timeText;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject losePanel;
    void Start()
    {
     //   winPanel.gameObject.SetActive(false);
       // losePanel.gameObject.SetActive(false); editor i�inden pobjenin tikini kald�rarrak da yapabilrdim ama ben ��z�m� b�yle buldum. yine de editorede de kapal� hat�rlamak i�in yzd�m

    }

    // Update is called once per frame
    void Update()
    {
        UpdateTheTimer();
       
        if (Time.time >= levelFinishTime && gameOver == false)
        {
            //print(Time.time);
            gameFinished = true;
            //print("Oyun bitti");
            losePanel.gameObject.SetActive(false);
            winPanel.gameObject.SetActive(true);
        }
        if (gameOver == true)
        {
            winPanel.gameObject.SetActive(false);
            losePanel.gameObject.SetActive(true);
        }
    }
    private void UpdateTheTimer()
    {
        timeText.text = "Time: " + (int)Time.time; // �n�ndeki (int) casting yap�yor. art�k float�m� integer. �rne�in matara dolduruyoz vsvs

    }


}

