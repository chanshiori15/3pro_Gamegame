using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectScript : MonoBehaviour
{
    public Text MainText;
    //public Text input;
    public InputField input1;
    public InputField input2;
    public InputField input3;

    public Text toDo1;
    public Text toDo2;
    public Text toDo3;

    string TODO1=null;
    string TODO2=null;
    string TODO3=null;

    public GameObject inputField1;
    public GameObject inputField2;
    public GameObject inputField3;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    public static string[] toDo;
    public static float time;

    public GameObject StartButton;

    // Start is called before the first frame update
    void Start()
    {
        MainText.text = "何分後に\nお知らせしますか？";
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log(TODO1);
        Debug.Log(TODO2);
        Debug.Log(TODO3);*/
        //Debug.Log(toDo[0]);

        if(TODO1!=null && TODO2!=null && TODO3 != null)
        {
            StartButton.SetActive(true);
        }

    }

    public void OnClick1()
    {
        time = 900.0f; //15分は900秒
        Debug.Log(time);
        SetText();
    }

    public void OnClick2()
    {
        time = 1800.0f; //30分は1800秒
        Debug.Log(time);
        SetText();
    }

    public void OnClick3()
    {
        time = 3600.0f; //1時間は3600秒
        Debug.Log(time);
        SetText();
    }

    void SetText()
    {
        MainText.text = "今日のToDoを\n入力してください";
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        inputField1.SetActive(true);
        inputField2.SetActive(true);
        inputField3.SetActive(true);
        input1 = input1.GetComponent<InputField>();
        input2 = input2.GetComponent<InputField>();
        input3 = input3.GetComponent<InputField>();
    }

    public void InputText()
    {
        toDo1.text = input1.text;
        toDo2.text = input2.text;
        toDo3.text = input3.text;

        TODO1 = toDo1.ToString();
        TODO2 = toDo2.ToString();
        TODO3 = toDo3.ToString();

        toDo = new string[] { TODO1, TODO2, TODO3 };
        /*Debug.Log(TODO1);
        Debug.Log(TODO2);
        Debug.Log(TODO3);*/

    }

    public void OnStart()
    {
        SceneManager.LoadScene("CountDown");
    }
    /*public void setToDo()
    {
        toDo = new string[] { TODO1, TODO2, TODO3 };
    }*/
}
