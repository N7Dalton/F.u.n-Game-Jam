using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float Doorlevel;
    public Animator doorAnimator;
    public Transform[] openLevelTransforms;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        Doorlevel = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator LevelUpDoor()
    {
        Doorlevel++;
        if (Doorlevel == 1f)
        {
            doorAnimator.Play("Door");
            new WaitForSeconds(0.1f);
            //transform.Rotate(0, 7, 0);
            yield return null;
        }
        if (Doorlevel == 2f)
        {
            doorAnimator.Play("Door(1)");
            new WaitForSeconds(0.1f);
            //transform.Rotate(0, 7, 0);
            yield return null;
        }
        if (Doorlevel == 3f)
        {
            doorAnimator.Play("Door(2)");
            new WaitForSeconds(0.1f);
            //transform.Rotate(0, 7, 0);
            yield return null;
        }
        if (Doorlevel == 4f)
        {
            doorAnimator.Play("Door(3)");
            new WaitForSeconds(0.1f);
            //transform.Rotate(0, 7, 0);
            yield return null;
        }
        if (Doorlevel == 5f)
        {
            doorAnimator.Play("Door(4)");
            new WaitForSeconds(0.1f);
            //transform.Rotate(0, 7, 0);
            yield return null;
        }
        if (Doorlevel == 6f)
        {
            doorAnimator.Play("Door(5)");
            new WaitForSeconds(0.1f);
            //transform.Rotate(0, 7, 0);
            yield return null;
        }
      
    }
  
   
    
}
