using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public int scoreAmount = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // a�a��daki metod objenin is trigger  bir girdi bir d�n�� sa�l�yor
    // objenin isTrigger se��ene�i se�ili, tikli ise,other is trigger'�n i�inden ge�en objeyi d�n�yor. (yani playera ula��caz)  */
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>(); //score manager'� referans ald�k.
            scoreManager.score += scoreAmount;
            Destroy(gameObject); // buradaki game object bu scripptin tak�l� oldu�u game object
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>(); //score manager'� referans ald�k.
            scoreManager.score += scoreAmount;
            Destroy(gameObject); // buradaki game object bu scripptin tak�l� oldu�u game object
        }

    }
}
