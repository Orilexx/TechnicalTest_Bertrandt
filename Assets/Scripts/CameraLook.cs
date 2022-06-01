
using UnityEngine;
using Cinemachine;


[RequireComponent(typeof(CinemachineFreeLook))]
public class CameraLook : MonoBehaviour
{

    [SerializeField] private float lookSpeed = 1f;

    private CinemachineFreeLook cinemachine;

    private Character playerInput;



    void Awake()
    {
        playerInput = new Character();
        cinemachine = GetComponent<CinemachineFreeLook>();
    }
   

    // Update is called once per frame
    void Update()
    {
        Vector2 delta = playerInput.CharacterC.Look.ReadValue<Vector2>();
        cinemachine.m_XAxis.Value += delta.x * lookSpeed * Time.deltaTime;
        cinemachine.m_YAxis.Value += delta.y * lookSpeed * Time.deltaTime;
    }


    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

}
