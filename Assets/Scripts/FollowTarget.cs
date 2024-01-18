using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;
    [SerializeField] private float speed;
    
    void Update()
    {
        sphere.transform.position = Vector3.MoveTowards(sphere.transform.position, cube.transform.position, speed * Time.deltaTime);
    }
}
