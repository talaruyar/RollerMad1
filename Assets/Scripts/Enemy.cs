using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speedOfEnemy = 3f;
    [SerializeField] private float stopDistance = 1f;
   

    // Start is called before the first frame update
    void Start()
    {
         // find with tag tüm objeleri tarýuyor, tag'i olan objeleri ayýrýyor, bizim týrnak içerisinde yazdýðýmýz tag'e dsahip objeleri buluyor
        target = GameObject.FindWithTag("Player").GetComponent<Transform>(); // burada yaptýðýmýz tag üzerinden objeyi bulup ccomponentine eriþmekti. runtime esnasýnda referans almamýz gerektiðpinde böyle kullanabiliriz.
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);   
            float distance = Vector3.Distance(transform.position, target.position);
            
            if (distance > stopDistance)
            {
                transform.position += transform.forward * speedOfEnemy * Time.deltaTime;
            }
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && target !=null )
        {           
            Destroy(collision.gameObject);
            TimeManager timeManager = FindObjectOfType<TimeManager>();
            //timeManager.gameOver = true;
            
        }
    }

  
}
