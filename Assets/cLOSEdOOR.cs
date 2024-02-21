using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cLOSEdOOR : MonoBehaviour
{
    public GameObject door;
    public AudioSource slam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        door.transform.Rotate(0, -90, 0);
        slam.Play();
    }
}
