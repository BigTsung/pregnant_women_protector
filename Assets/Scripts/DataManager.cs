using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : Singleton<DataManager>
{  
    private List<Food> foods = new List<Food>();
    void Start()
    {
        Debug.Log("Application.persistentDataPath: " + Application.persistentDataPath);
        string text = LoadJsonfile(Path.Combine(Application.persistentDataPath, "Foods.json"));
        Food[] food = JsonHelper.FromJson<Food>(text);
        foods = new List<Food>(food);
    }

    private string LoadJsonfile(string path)
    {
        string targetStr = File.ReadAllText(path);
        return targetStr;
    }

    public Food GetFoodByName(string foodName)
    {
        Food food = foods.Find(x => x.name == foodName);
        return food;
    }

    public bool AddNewFoodToLocalFoodDatabase(Food food)
    {
        if(food == null && GetFoodByName(food.name) != null)
        {
            return false;
        }

        foods.Add(food);
        return true;
    }

    public bool UpdateFoodInfoInLocalFoodDatabase(Food food)
    {
        int foodIndex = foods.FindIndex(x => x.name == food.name);
        if(foodIndex >= 0)
        {
            foods[foodIndex] = food;
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public void ExportJson()
    {
        Food food = new Food();
        string jsonStr = JsonHelper.ToJson<Food>(foods.ToArray(), true);
        File.WriteAllText(Path.Combine(Application.persistentDataPath, "Foods.json"), jsonStr);
    }
}
