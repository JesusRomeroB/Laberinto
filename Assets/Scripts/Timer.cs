using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timer;
    public float time;
    float msec;
    float sec;
    float min;

    IEnumerator StopWatch()
    {
        while (true)
        {
            time += Time.deltaTime;
            msec = (int)((time - (int)time) * 100);
            sec = (int)(time % 60);
            min = (int)(time / 60 % 60);
            timer.text = string.Format("{0:00}:{1:00}:{2:00}", min, sec, msec);

            yield return null;
        }

    }
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine("StopWatch");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
