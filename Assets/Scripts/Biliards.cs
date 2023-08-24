using UnityEngine;

public class Biliards : MonoBehaviour
{
    [SerializeField] float Power;   // сила удара битка
    private Rigidbody cueBall;      // биток

    void Start()
    {
        cueBall = GetComponent<Rigidbody>();

        HitCueBall();
    }

    /// <summary>
    /// ѕриводит в движение биток
    /// </summary>
    private void HitCueBall()
    {
        cueBall.AddForce(Vector3.back * Power, ForceMode.Impulse);
    }
}
