using UnityEngine;
using UnityEngine.InputSystem;

public class CannonRotate : MonoBehaviour
{
    [SerializeField] private GameObject _cannon;

    private float m_cannonRotation;

    [SerializeField] private float _cannonRotationStep;
    [SerializeField] private float _cannonRotationClamp;

    private void FixedUpdate()
    {
        _cannon.transform.eulerAngles = new Vector3(0f, 0f, Mathf.Clamp(m_cannonRotation, _cannonRotationClamp, _cannonRotationClamp));
    }

    public void Rotate(InputAction.CallbackContext value)
    {
        m_cannonRotation -= value.ReadValue<Vector2>().x * _cannonRotationStep;
    }
}
