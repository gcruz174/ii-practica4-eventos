using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float rotationSpeed;
    public float movementSpeed;

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up, horizontal * rotationSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * (vertical * movementSpeed * Time.deltaTime));
    }
}
