using UnityEngine;

public class FollowPlayerOnHold : MonoBehaviour
{
    public Vector3 playerPosition;
    private Vector3 _currentPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentPosition = transform.position + playerPosition;
        }
    }
}
