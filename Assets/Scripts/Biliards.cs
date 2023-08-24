using UnityEngine;

public class Biliards : MonoBehaviour
{
    [SerializeField] float Power;   // ���� ����� �����
    private Rigidbody cueBall;      // �����

    void Start()
    {
        cueBall = GetComponent<Rigidbody>();

        HitCueBall();
    }

    /// <summary>
    /// �������� � �������� �����
    /// </summary>
    private void HitCueBall()
    {
        cueBall.AddForce(Vector3.back * Power, ForceMode.Impulse);
    }
}
