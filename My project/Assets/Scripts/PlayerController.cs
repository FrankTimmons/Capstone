using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public Transform viewPoint;
  public float mouseSensitivity = 3f;
  private float verticalRotationStore;
  private Vector2 mouseInput;

  public bool invertLook;

  public float moveSpeed = 5f, runSpeed = 8f;
  private float activeMoveSpeed;
  private Vector3 moveDir, movement;

  public CharacterController charCon;

  private Camera cam;

  public float jumpForce = 12f, gravityMod = 2.5f;

  public Transform groundCheckPoint;
  private bool isGrounded;
  public LayerMask groundLayers;

  public GameObject bulletImpact;

  // Start is called before the first frame update
  void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;

    cam = Camera.main;
  }

  // Update is called once per frame
  void Update()
  {
    mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * mouseSensitivity;

    transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);

    verticalRotationStore += mouseInput.y;

    verticalRotationStore = Mathf.Clamp(verticalRotationStore, -60f, 60f);

    if(invertLook == true)
    {
      viewPoint.rotation = Quaternion.Euler(verticalRotationStore, viewPoint.rotation.eulerAngles.y, viewPoint.rotation.eulerAngles.z);
    } 
    else
    {
      viewPoint.rotation = Quaternion.Euler(-verticalRotationStore, viewPoint.rotation.eulerAngles.y, viewPoint.rotation.eulerAngles.z);
    }

    moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));

    if(Input.GetKey(KeyCode.LeftShift))
    {
      activeMoveSpeed = runSpeed;
    } 
    else
    {
      activeMoveSpeed = moveSpeed;
    }

    float yVel = movement.y;
    movement = ((transform.forward * moveDir.z) + (transform.right * moveDir.x)).normalized * activeMoveSpeed;
    movement.y = yVel;

    if(charCon.isGrounded)
    {
      movement.y = 0f;
    }

    isGrounded = Physics.Raycast(groundCheckPoint.position, Vector3.down, .25f, groundLayers);

    if(Input.GetButtonDown("Jump") && isGrounded)
    {
      movement.y = jumpForce;
    }

    movement.y += Physics.gravity.y * Time.deltaTime * gravityMod;
    charCon.Move(movement * Time.deltaTime);

    if(Input.GetMouseButtonDown(0))
    {
      Shoot();
    }

    if (Input.GetKeyDown(KeyCode.Escape))
    {
      Cursor.lockState = CursorLockMode.None;
    } 
    else if(Cursor.lockState == CursorLockMode.None)
    {
      if (Input.GetMouseButtonDown(0))
      {
        Cursor.lockState = CursorLockMode.Locked;
      }
    }
  }

  private void Shoot()
  {
    Ray ray = cam.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
    ray.origin = cam.transform.position;

    if (Physics.Raycast(ray, out RaycastHit hit))
    {
      GameObject bulletImpactObject = Instantiate(bulletImpact, hit.point + (hit.normal * .002f), Quaternion.LookRotation(hit.normal, Vector3.up));

      Destroy(bulletImpactObject, 10f);
    }
  }

  private void LateUpdate()
  {
    cam.transform.position = viewPoint.position;
    cam.transform.rotation = viewPoint.rotation;
  }
}
