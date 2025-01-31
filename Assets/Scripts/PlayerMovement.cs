using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private PlayerControls playerControls;

    [SerializeField]
    private float movementSpeed = 1.0f;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    void Update()
    {
        Vector2 inputVector = playerControls.Player.Move.ReadValue<Vector2>();
        Vector3 movementVector = new Vector3(inputVector.x, 0f, inputVector.y);

        transform.Translate(movementVector * movementSpeed * Time.deltaTime);

    }
}
