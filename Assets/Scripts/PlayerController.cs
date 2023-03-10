using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    [SerializeField]AudioManager _audioManager;
    Animator animator;
    Camera mainCamera;
    public GameObject firstKitBag;
    [SerializeField] float rotationSpeed;
    TakeableObjects takeableObjects;
    public bool isCrouch;
    public bool fKeyIsPush;
    void Start()
    {
        animator = GetComponent<Animator>();
        mainCamera = Camera.main;
    }
    void Update()
    {
        Movement();
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            _audioManager.playOneShotAudioClip("tab");
            Objects.tabMenuIsOpen = !Objects.tabMenuIsOpen;
            Objects.image.SetActive(Objects.tabMenuIsOpen);
        }
        if(Input.GetKeyDown(KeyCode.LeftControl)){
            isCrouch = !isCrouch;
            animator.SetBool("isCrouch",isCrouch);
        }
        if(Input.GetKeyDown(KeyCode.F) && takeableObjects !=null && takeableObjects.IsArea ){
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
    void fPress(){
        fKeyIsPush = true;
    }
    void fDontPress(){
        fKeyIsPush = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if(EarthquakeBag.qitFinish && !Earthquake.earthquakeIsStart && other.gameObject.tag.Equals("LastScene")){
           SceneManager.LoadScene(2);
        }
        
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<ITakeable>()!=null){
            takeableObjects = other.gameObject.GetComponent<TakeableObjects>();
            takeableObjects.IsArea = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(takeableObjects!=null)
            takeableObjects.IsArea = false;
    }
}
