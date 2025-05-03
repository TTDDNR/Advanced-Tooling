using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class FrameCounter : MonoBehaviour
{
    public int avgFrameRate;
    public TMP_Text display_Text;

    public void FixedUpdate()
    {
        float current = 0;
        current = Time.frameCount / Time.time;
        avgFrameRate = (int)current;
        WriteString(avgFrameRate.ToString());
        display_Text.text = avgFrameRate.ToString() + " FPS";
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
