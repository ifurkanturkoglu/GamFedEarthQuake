using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    Animator animator;
    Camera mainCamera;
    [SerializeField] float rotationSpeed;
    public bool isCrouch;
    void Start()
    {
        animator = GetComponent<Animator>();
        mainCamera = Camera.main;
    }
    void Update()
    {
        Movement();
        if(Input.GetKeyDown(KeyCode.LeftControl)){
            isCrouch = !isCrouch;
            animator.SetBool("isCrouch",isCrouch);
        }
        if(Input.GetKeyDown(KeyCode.F)){
            animator.SetTrigger("isPickUp");
        }
    }
    private void Movement()
    {
        float verticalInput = Input.GetKey(KeyCode.W) ? 1 : 0;
        var directionInput = new Vector3(0, 0, verticalInput);

        float yawCamera = mainCamera.transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), rotationSpeed * Time.deltaTime);
        
        animator.SetFloat("speed", directionInput.magnitude);
    }
    void OnTriggerEnter(Collider other)
    {
        if(EarthquakeBag.qitFinish && !Earthquake.earthquakeIsStart && other.gameObject.tag.Equals("LastScene")){
           SceneManager.LoadScene(2);
        }
    }
}
