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
         // find with tag t�m objeleri tar�uyor, tag'i olan objeleri ay�r�yor, bizim t�rnak i�erisinde yazd���m�z tag'e dsahip objeleri buluyor
        target = GameObject.FindWithTag("Player").GetComponent<Transform>(); // burada yapt���m�z tag �zerinden objeyi bulup ccomponentine eri�mekti. runtime esnas�nda referans almam�z gerekti�pinde b�yle kullanabiliriz.
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        

        float distance = Vector3.Distance(transform.position, target.position);
        print(distance);
        if (distance > stopDistance)
        {
            transform.position += transform.forward * speedOfEnemy * Time.deltaTime;
        }
      

    }
     
  
}
