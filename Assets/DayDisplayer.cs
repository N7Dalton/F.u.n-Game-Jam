using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayDisplayer : MonoBehaviour
{
    public int DayCount = 1;
    public string text;
    public TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        UpdateDayCount();
        DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        if (textMeshPro == null)
        {
            textMeshPro = GameObject.FindWithTag("TMP").GetComponent<TextMeshProUGUI>();
        }
        text = $"Day {DayCount}";
        textMeshPro.text = text;
       
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void UpdateDayCount()
    {
        DayCount++;
        Debug.Log(DayCount);
    }
}
