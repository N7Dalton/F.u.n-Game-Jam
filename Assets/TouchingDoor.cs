using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.UI;

public class TouchingDoor : MonoBehaviour
{
    public Animator Dadanimator;
    public Animator playeranimator;
    public TextMeshProUGUI textMeshProUGUI;
    public string[] strings;
    public Door doorScript;
    public GameObject dadsleepin;
    public GameObject dadchasin;
    public GameObject dorr;
    public AudioSource BOOM;
    public AudioSource buildUpSound;
    void OnTriggerEnter()
    {
        if(doorScript.Doorlevel <= 6f)
        {
            BOOM.Play();
            Dadanimator.Play("DadMadAnim");
            StartCoroutine(doorScript.LevelUpDoor());
            textMeshProUGUI.text = RandomString();
        }
       else if(doorScript.Doorlevel == 7f)
        {
            buildUpSound.Play();
            StartCoroutine(doorScript.LevelUpDoor());
            dorr.transform.Rotate(0, 90, 0);
            Debug.Log("rotate dorr");
            dadsleepin.SetActive(false);
            dadchasin.SetActive(true);
        }
       
    }
    public string RandomString()
    {
        return strings[Random.Range(0, strings.Length )];
    }
}
