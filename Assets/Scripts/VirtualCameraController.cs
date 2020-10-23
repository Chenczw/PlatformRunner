using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VirtualCameraController : MonoBehaviour
{
    public List<GameObject> VirtualCamera;

    // Start is called before the first frame update
    void Start()
    {
        VirtualCamera.Clear();
        for (int i = 0; i < transform.childCount; i++)
        {
            VirtualCamera.Add(transform.GetChild(i).gameObject);
        }
    }


    public void TransitionTo(GameObject cameraToTransitionTo)
    {
        foreach (GameObject g in VirtualCamera)
        {
            if (g == cameraToTransitionTo)
            {
                //Transition to that camera
                g.GetComponent<CinemachineVirtualCamera>().Priority = 10;
            }
            else
            {
                //De-priority camera
                g.GetComponent<CinemachineVirtualCamera>().Priority = 5;
            }
        }
    }
}
