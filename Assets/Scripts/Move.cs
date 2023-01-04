using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
        /* Start is called before the first frame update
    [SerializeField] de�i�keninn access'i private bile olsa inspector'dan eri�ilir k�l�yo.
        ba�ka scriptlerden eri�ilemesin ama mesela inspector'dan eri�ilebilrsin gibi bir durum olablir.

    [HideInInspector] 'da de�i�kenin access modifier'� ouvlica bile olsa inspector'dan eri�ilmez k�l�yo
    */

    private Vector3 movement;
    [SerializeField] private float speed = 10f;
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlayer();
    }

    private void MoveThePlayer()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        movement = new Vector3(x, 0f, z);
        // transform.position += movement; soldaki de�erle sa�daki de�eri topla ve sonucu soldakine ata
        rigidbody.AddForce(movement);
    }
}