using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private Transform hoursPivot;
    [SerializeField] private Transform minutesPivot;
    [SerializeField] private Transform secondsPivot;

    private const float hoursRotation = -30;
    private const float minutesRotation = -6;
    private const float secondsRotation = -6;

    private void Update()
    {
        TimeSpan timeSpan = DateTime.Now.TimeOfDay;
        
        hoursPivot.localRotation = Quaternion.Euler(0f,0f, hoursRotation * (float) timeSpan.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f,0f, minutesRotation * (float) timeSpan.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f,0f, secondsRotation * (float) timeSpan.TotalSeconds);
    }
}
