using UnityEngine;

public class Superman : MonoBehaviour
{
    private Transform superman;     // супермен

    [SerializeField] float Power;   // сила удара супермена
    void Start()
    {
        superman = GetComponent<Transform>();
    }

    /// <summary>
    /// При столкновении с врагом, ударяет его
    /// </summary>
    /// <param name="collision"></param>
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
