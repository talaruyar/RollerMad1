using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // user interface kütüphanesini çekmek için. canvas üzeirnde iþlemler yapabilmek için bu lazým


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
       // losePanel.gameObject.SetActive(false); editor içinden pobjenin tikini kaldýrarrak da yapabilrdim ama ben çözümü böyle buldum. yine de editorede de kapalý hatýrlamak için yzdým

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
        timeText.text = "Time: " + (int)Time.time; // önündeki (int) casting yapýyor. artýk floatýmý integer. örneðin matara dolduruyoz vsvs

    }


}

