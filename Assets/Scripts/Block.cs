using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Block : MonoBehaviour
{
    private bool isCollided = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // scriptinbaðlý olduðu nesnenin (block) herhangi bi obje çarpýnca onunla fiziksel
    // etkileþime giriyo. onu tutuyo. bir kez çalýþýuyor */

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (isCollided == false)
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
                ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
                scoreManager.score--;
                print(scoreManager.score);
                isCollided = true;
            }
        }
       
       
    }
}
