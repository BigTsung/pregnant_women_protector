using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FoodDescriptionItem : MonoBehaviour
{
    [SerializeField]
    private Text foodNameText;
    // private TextMeshProUGUI foodNameText;
    [SerializeField]
    private Image danguousLighting;
    [SerializeField]
    private Text descriptionText;

    private void SetFoodNameText(string foodName)
    {
        if(foodNameText != null)
        {
            // foodNameText.SetText(foodName);
            Debug.Log(foodName);
            foodNameText.text = foodName;
        }
    }

    private void SetDanguageLighting(int level)
    {
        if(danguousLighting != null)
        {
            Color color = Color.red; 
            if(level == 0)
                color = Color.green;
            else if(level == 1)
                color = Color.yellow;
            else if(level == 2)
                color = Color.red;
            else
                color = Color.red;

            danguousLighting.color = color;
        }
    }

    private void SetDescriptionText(string description)
    {
        if(descriptionText != null)
        {
            descriptionText.text = description;
        }
    }
    public void RefreshAll(Food targetFood)
    {
        if(targetFood == null)
        {
            Debug.LogWarning("targetFood in null");
            return;
        }

        SetFoodNameText(targetFood.name);
        SetDanguageLighting(targetFood.dangerous);
        SetDescriptionText(targetFood.description);
    }
}
