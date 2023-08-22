using UnityEngine;

public class Biliards : MonoBehaviour
{
    [SerializeField] float Power;
    private Rigidbody cueBall;

    void Start()
    {
        cueBall = GetComponent<Rigidbody>();

        HitCueBall();
    }

    private void HitCueBall()
    {
        cueBall.AddForce(Vector3.back * Power, ForceMode.Impulse);
    }
}
