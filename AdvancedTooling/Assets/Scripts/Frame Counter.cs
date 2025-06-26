using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class FrameCounter : MonoBehaviour
{
    public int avgFrameRate;
    public TMP_Text display_Text;

    private float fps = 30f;
    private float newFPS = 30f;

    public float updateInterval = 1.0f;

    private int frames = 0;
    private float timePassed = 0f;

    private float timeElapsed;
    private int frameCount;
    private float currentFPS;

    public float CurrentFPS => currentFPS; // Use this if you want to access it elsewhere
    public void FixedUpdate()
    {
        /*float current = 0;
        current = Time.frameCount / Time.time;
        avgFrameRate = (int)current;
        WriteString(avgFrameRate.ToString());
        display_Text.text = avgFrameRate.ToString() + " FPS";*/

        /*newFPS += (Time.unscaledDeltaTime - newFPS) * 0.1f;
        float fps = 1.0f / newFPS;
        *//*newFPS = 1.0f / Time.smoothDeltaTime;
        fps = Mathf.Lerp(fps, newFPS, 0.0005f);*//*
        display_Text.text = fps.ToString() + " FPS";*/

        /*frames++;
        timePassed += Time.unscaledDeltaTime;

        if (timePassed >= updateInterval)
        {
            int fps = Mathf.RoundToInt(frames / timePassed);
            display_Text.text = $"FPS: {fps}";

            // Reset for next interval
            frames = 0;
            timePassed = 0f;
        }*/

        display_Text.text = (UnityStats.frameTime*1000).ToString() + " ms";
        WriteString((UnityStats.frameTime * 1000).ToString());

        /*frameCount++;
        timeElapsed += Time.unscaledDeltaTime;

        if (timeElapsed >= updateInterval)
        {
            currentFPS = frameCount / timeElapsed;

            Debug.Log($"Actual FPS: {currentFPS:F1}"); // Optional: log to console

            display_Text.text = currentFPS.ToString() + " FPS";
            WriteString(currentFPS.ToString());

            frameCount = 0;
            timeElapsed = 0f;
        }*/
    }

    public static void WriteString(string FPS)
    {
        string path = Application.persistentDataPath + "/FrameRates.txt";
        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(FPS);
        writer.Close();
    }
}
