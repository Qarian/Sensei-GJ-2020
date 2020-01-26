using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour
{

    public Animator brwi;

    void    playbrwi()
    {
        brwi.enabled = true;
            brwi.Play(0);
    }
    public void CrashWin()
    {
        
             string path = Application.streamingAssetsPath;
            System.Diagnostics.Process.Start(path+ "/notmyfaultc.exe", " crash 0x01");
    }
}
