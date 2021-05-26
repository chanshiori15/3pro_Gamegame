using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    //public SelectScript selectScript;
    public Text timerLabel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerLabel.text = SelectScript.time.ToString("f1");
    }

    public void OnClick()
    {
        SelectScript.time -= Time.deltaTime;
    }
}
