using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _maxPositionZ;
    [SerializeField] private float _minPositionZ;
    [SerializeField] private float _speed;

    private Vector3 _direction = Vector3.forward;

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);

        if (transform.position.z >= _maxPositionZ)
            _direction = Vector3.back;

        if (transform.position.z <= _minPositionZ)
            _direction = Vector3.forward;
    }
}
