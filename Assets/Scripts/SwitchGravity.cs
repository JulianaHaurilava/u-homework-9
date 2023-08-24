using UnityEngine;

public class SwitchGravity : MonoBehaviour
{
    /// <summary>
    /// При соприкосновении со сферой невесомости, отключает гравитацию для объекта
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.useGravity = false;
    }

    /// <summary>
    /// При выхода из сферы невесомости, включает гравитацию для объекта
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        other.attachedRigidbody.useGravity = true;
    }
}
