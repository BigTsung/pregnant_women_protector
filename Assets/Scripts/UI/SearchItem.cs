using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchItem : MonoBehaviour
{
    private string targetFoodName = "";
    public void OnSearchInputFieldChange(string content)
    {
        // Debug.Log(content);
        targetFoodName = content;
    }

     public void OnSearchButtonClick()
     {
        Debug.Log(DataManager.Instance.GetFoodByName(targetFoodName).name);
     }
}
