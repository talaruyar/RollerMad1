using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private float cameraFollowSpeed = 5f;

    private Vector3 offsetVector;
    void Start()
    {
        offsetVector = CalculateOffset(target);
    }
    void FixedUpdate()
    {
        MoveTheCamera();
    }
    
    private void MoveTheCamera()
    {

        /*  Vector3.Lerp(Vector3 a, Vector3 b, float t); iki nokta aras�nda verilen bir zamanda �izgisel ge�i� sa�lar
        Vector3 targetToMove = target.position + offsetVector;
        farkl� scriptlerdeki update metodlar �ak���p smooth bir g�r�nt� olu�ltrmas�na engel olaca��ndan buradaki up�date metodu fixed update olarak de�i�tirdik. 
        fixed update update'den sonra, fiziksel hesaplamalardan sonra �al���r. o y�zden bu gariplik ya�anmaz
                 */

        if (target != null)
        {
            Vector3 targetToMove = target.position + offsetVector;
            transform.position = Vector3.Lerp(transform.position, targetToMove, cameraFollowSpeed * Time.deltaTime);
            transform.LookAt(target.transform.position);
        }
       
    }

    private Vector3 CalculateOffset(Transform newTarget)
    {
        return transform.position - newTarget.position;
    }

}