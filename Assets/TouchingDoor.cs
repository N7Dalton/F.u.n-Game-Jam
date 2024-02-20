using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TouchingDoor : MonoBehaviour
{
    public Animator Dadanimator;
    public Animator playeranimator;
    public TextMeshProUGUI textMeshProUGUI;
    public string[] strings;
    void OnTriggerEnter()
    {
        
        Dadanimator.Play("DadMadAnim");
        
        textMeshProUGUI.text = RandomString();
    }
    public string RandomString()
    {
        return strings[Random.Range(0, strings.Length )];
    }
}
