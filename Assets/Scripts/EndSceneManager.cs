using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class EndSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI _text;
    // Start is called before the first frame update
    void Start()
    {
        string endText = PlayerPrefs.GetString("EndText");
        _text.text = endText;
    }

    // Update is called once per frame
    public void OnRestartClick()
    {
        SceneManager.LoadScene("StartScene");
    }
    

    // Update is called once per frame
    void Update()
    {

    }
}
