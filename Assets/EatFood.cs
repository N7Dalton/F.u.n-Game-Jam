using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFood : MonoBehaviour
{
    public GameMan gamemanScript;
    public GameObject PlateWFood;
    public GameObject PlateWOFood;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        animator.Play("txt3");
       
    }
    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.Play("txt2");
            PlateWFood.SetActive(false);
            PlateWOFood.SetActive(true);
            gamemanScript.HasEaten = true;
        }
    }
}
