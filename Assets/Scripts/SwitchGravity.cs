using UnityEngine;

public class SwitchGravity : MonoBehaviour
{
    /// <summary>
    /// ��� ��������������� �� ������ �����������, ��������� ���������� ��� �������
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.useGravity = false;
    }

    /// <summary>
    /// ��� ������ �� ����� �����������, �������� ���������� ��� �������
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        other.attachedRigidbody.useGravity = true;
    }
}
