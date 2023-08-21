using System;
using System.Reflection;
using UnityEngine;

public class Superman : MonoBehaviour
{
    private Transform superman;

    [SerializeField] float Power;
    void Start()
    {
        superman = GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null
            && collision.gameObject.layer == 7)
        {
            Vector3 enemy_position = collision.gameObject.transform.position;
            Vector3 superman_position = superman.position;

            collision.rigidbody.AddForce((enemy_position - superman_position).normalized * Power,
                ForceMode.Impulse);
        }
    }
}
