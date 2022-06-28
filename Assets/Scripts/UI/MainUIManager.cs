using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIManager : Singleton<MainUIManager>
{
    [SerializeField]
    private GameObject foodDescriptionItemGameObject;
    [SerializeField]
    private GameObject foodDescriptionContentGameObject;
    [SerializeField]
    private GameObject foodDescriptionNothinGameObject;
    [SerializeField]
    private GameObject searchItemGameObject;

    private FoodDescriptionItem foodDescriptionItem;
    private SearchItem searchItem;

    private void Awake()
    {
        if(foodDescriptionItemGameObject != null)
        {
            foodDescriptionItem = foodDescriptionItemGameObject.GetComponent<FoodDescriptionItem>();
        }
        if(searchItemGameObject != null)
        {
            searchItem = searchItemGameObject.GetComponent<SearchItem>();
        }
    }

    private void SetActiveFoodDescriptionContent(bool status)
    {
        if(foodDescriptionContentGameObject != null)
        {
            foodDescriptionContentGameObject.SetActive(status);
        }
    }

    private void SetActiveFoodDescriptionNothing(bool status)
    {
        if(foodDescriptionNothinGameObject != null)
        {
            foodDescriptionNothinGameObject.SetActive(status);
        }
    }

    // private void SetActiveSearchItem(bool status)
    // {
    //     if(searchItemGameObject != null)
    //     {
    //         searchItemGameObject.SetActive(status);
    //     }
    // }

    public void RefreshTargetFoodDescriptionItem(string targetFoodName)
    {
        Food targetFood = DataManager.Instance.GetFoodByName(targetFoodName);
        bool notFoundAnyFood = targetFood == null;

        SetActiveFoodDescriptionNothing(notFoundAnyFood);
        SetActiveFoodDescriptionContent(!notFoundAnyFood);

        if(notFoundAnyFood)
        {
            Debug.Log("Not found any food in your local food database");
        }
        else
        {
            Debug.Log("Target food is: " + targetFood.name);
            
            foodDescriptionItem.RefreshAll(targetFood);
        }
    }
}
