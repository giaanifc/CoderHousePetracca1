using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    [SerializeField] private CinemachineVirtualCamera cam1;
    [SerializeField] private CinemachineVirtualCamera cam2;

    // Start is called before the first frame update
    void Start()
    {
       
    }


    private void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            CameraFunction(cam1, cam2);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            CameraFunction(cam2, cam1);
        }
    }

    private void CameraFunction(CinemachineVirtualCamera camNumber, CinemachineVirtualCamera camOff)
    {
        camNumber.gameObject.SetActive(true);
        camOff.gameObject.SetActive(false);
    }
}
