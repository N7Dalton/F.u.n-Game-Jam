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
    public float doorlevl = 0f;
    public GameObject dadsleepin;
    public GameObject dadchasin;
    public GameObject dorr;
    public AudioSource BOOM;
    public AudioSource buildUpSound;
    void OnTriggerEnter()
    {
        if(doorlevl <= 6f)
        {
            doorlevl++;
            BOOM.Play();
            Dadanimator.Play("DadMadAnim");
            dorr.transform.Rotate(-7, 0, 0);

            textMeshProUGUI.text = RandomString();
        }
       else if(doorlevl == 7f)
        {
            buildUpSound.Play();
            dorr.transform.Rotate(-70, 0, 0);
            dorr.transform.Rotate(-7, 0, 0);
            StartCoroutine("LevelUpDoor");
            BOOM.Play();
            BOOM.Play();
            dadsleepin.SetActive(false);
            dadchasin.SetActive(true);

        }
       
    }
    public string RandomString()
    {
        return strings[Random.Range(0, strings.Length )];
    }
    public IEnumerator LevelUpDoor()
    {

        if (doorlevl == 1f)
        {


           
            yield return null;
        }
        if (doorlevl == 2f)
        {

            transform.Rotate(-7, 0, 0);
            yield return null;
        }
        if (doorlevl == 3f)
        {

            transform.Rotate(-7, 0, 0);
            yield return null;
        }
        if (doorlevl == 4f)
        {

            transform.Rotate(-7, 0, 0);
            yield return null;
        }
        if (doorlevl == 5f)
        {

            transform.Rotate(-7, 0, 0);
            yield return null;
        }
        if (doorlevl == 6f)
        {


            transform.Rotate(-7, 0, 0);
            yield return null;
        }
        if (doorlevl == 7f)
        {

           
            yield return null;
        }

    }
}
