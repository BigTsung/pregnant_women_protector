using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    void OnApplicationQuit()
    {
        DataManager.Instance.ExportJson();
        Debug.Log("Application ending after " + Time.time + " seconds");
    }
}
