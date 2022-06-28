using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingUIManager : MonoBehaviour
{
    private string foodName = string.Empty;
    private string description = string.Empty;
    public void CloseMyself()
    {
        gameObject.SetActive(false);
    }

    public void OnClickAddingButton()
    {
        Food food = new Food();
        food.name = foodName;
        food.description = description;
        DataManager.Instance.AddNewFoodToLocalFoodDatabase(food);
    }

    public void OnChangedFoodNameInputField(string content)
    {
        foodName = content;
    }

    public void OnChangedDescriptionInputField(string content)
    {
        description = content;
    }
}
