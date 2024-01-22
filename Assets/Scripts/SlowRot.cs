using UnityEngine;

public class SlowRot : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float turnSpeed = .01f;
    private Quaternion _rotGoal;
    private Vector3 _direction;

    private void Update()
    {
        _direction = (target.position - transform.position).normalized;
        _rotGoal = Quaternion.LookRotation(_direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, _rotGoal, turnSpeed);
        //transform.rotation = _rotGoal;
    }
}
