using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : Singleton<DataManager>
{  
    private List<Food> foods = new List<Food>();
    void Start()
    {
        string text = LoadJsonfile(Path.Combine(Application.persistentDataPath, "Foods.json"));
        Food[] foodarr = JsonHelper.FromJson<Food>(text);
        foods = new List<Food>(foodarr);
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
        if(food == null)
        {
            return false;
        }

        foods.Add(food);
        return true;
    }
}
