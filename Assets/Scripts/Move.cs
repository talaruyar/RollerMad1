using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
        /* Start is called before the first frame update
    [SerializeField] deðiþkeninn access'i private bile olsa inspector'dan eriþilir kýlýyo.
        baþka scriptlerden eriþilemesin ama mesela inspector'dan eriþilebilrsin gibi bir durum olablir.

    [HideInInspector] 'da deðiþkenin access modifier'ý ouvlica bile olsa inspector'dan eriþilmez kýlýyo
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
        // transform.position += movement; soldaki deðerle saðdaki deðeri topla ve sonucu soldakine ata
        rigidbody.AddForce(movement);
    }
}