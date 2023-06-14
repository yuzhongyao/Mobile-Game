using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraFollow : MonoBehaviour
{
    CinemachineVirtualCamera camera;
    GameObject slime;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<CinemachineVirtualCamera>();
        slime = GameObject.FindWithTag("Player");
        camera.Follow = slime.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
