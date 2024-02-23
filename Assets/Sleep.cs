using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sleep : MonoBehaviour
{
    public Animator animatorforsleep;
    public GameMan gameman;
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
        if(gameman.HasEaten == true)
        animatorforsleep.Play("txt4");
    }
    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E) && gameman.HasEaten == true)
        {
            SceneManager.LoadScene(SceneManager.sceneCount + 1);
        }
    }
}
