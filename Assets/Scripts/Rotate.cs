using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] Vector3 rotationDirection;
    [SerializeField] float rotationSpeed;
    
    void Update()
    {
        transform.Rotate(rotationDirection, rotationSpeed);
    }
}
