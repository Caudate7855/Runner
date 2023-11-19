using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _maxLeft;
    [SerializeField] private float _maxRight;
    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
        }
    }

    public void TryMoveLeft()
    {
        if (_targetPosition.x > _maxLeft)
        {
            SetNextPosition(-_stepSize); 
        }
    }

    public void TryMoveRight()
    {
        if (_targetPosition.x < _maxRight)
        {
            SetNextPosition(_stepSize);
        }
    }

    private void SetNextPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x + stepSize ,_targetPosition.y);
    }
}
