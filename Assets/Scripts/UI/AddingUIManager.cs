using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddingUIManager : MonoBehaviour
{
    [SerializeField] private Text statusText;
    [SerializeField] private InputField foodNameInputField;
    [SerializeField] private TMP_Dropdown levelDropDown;
    [SerializeField] private InputField descriptionInputField;

    
    private string foodName = string.Empty;
    private string description = string.Empty;
    private int level = 0;

    private void SetStatusText(string content)
    {
        if(statusText != null)
        {
            statusText.text = content;
        }
    }

    private void SetFoodNameInputField(string content)
    {
        if(foodNameInputField != null)
        {
            foodNameInputField.text = content;
        }
    }

    private void SetLevelDropDown(int index)
    {
        if(levelDropDown != null)
        {
            levelDropDown.value = index;
        }
    }
    private void SetDescriptionInputField(string content)
    {
        if(descriptionInputField != null)
        {
            descriptionInputField.text = content;
        }
    }

    public void CloseMyself()
    {
        SetStatusText("");
        SetFoodNameInputField("");
        SetLevelDropDown(0);
        SetDescriptionInputField("");
        gameObject.SetActive(false);
    }

    public void OnClickAddingButton()
    {
        Food food = new Food();
        food.name = foodName;
        food.description = description;
        food.dangerous = level;
        bool added = DataManager.Instance.AddNewFoodToLocalFoodDatabase(food);
        if(added)
        {
            SetStatusText("已加入");
        }
        else
        {
            SetStatusText("已存在");
        }
    }

    public void OnChangedFoodNameInputField(string content)
    {
        foodName = content;
    }

    public void OnChangedDescriptionInputField(string content)
    {
        description = content;
    }

    public void OnDropDownValueChanged(int index)
    {
        Debug.Log("index: " + index);
        level = index;
    }

   
}
