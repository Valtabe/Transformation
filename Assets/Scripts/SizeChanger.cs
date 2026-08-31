using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxScale;
    [SerializeField] private float _minScale;

    private bool _isIncreased = true;

    void Update()
    {
        transform.localScale *= _isIncreased ? 1 + (_speed * Time.deltaTime) : 1 - (_speed * Time.deltaTime);

        if (transform.localScale.x >= _maxScale)
            _isIncreased = false;

        if (transform.localScale.x <= _minScale)
            _isIncreased = true;
    }
}
