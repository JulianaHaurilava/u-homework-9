using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    [SerializeField] int Power;             // сила взрыва
    [SerializeField] float Radius;          // радиус сферы взрыва
    [SerializeField] Timer explosionTimer;  // таймер, отсчитывающий время до следующего взрыва

    private Vector3 explosionPoint;
    private Collider[] objectsToExplode;


    void Start()
    {
        explosionPoint = transform.position;
    }

    private void Update()
    {
        if (explosionTimer.TaskCompleted)
        {
            Explode();
        }
    }

    /// <summary>
    /// Реализует взрыв
    /// </summary>
    private void Explode()
    {
        objectsToExplode = Physics.OverlapSphere(explosionPoint, Radius);
        foreach (Collider collider in objectsToExplode)
        {
            if (collider.gameObject.TryGetComponent(out Rigidbody rb))
            {
                Vector3 direction = rb.transform.position - explosionPoint;
                float distance = Vector3.Distance(rb.transform.position, explosionPoint);
                rb.AddForce(direction.normalized * Power * (Radius - distance), ForceMode.Impulse);
            }
        }
    }
}
