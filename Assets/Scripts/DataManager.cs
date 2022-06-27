using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : Singleton<DataManager>
{  
    private List<Food> foods = new List<Food>();
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(Application.persistentDataPath);
        string text = LoadJsonfile(Path.Combine(Application.persistentDataPath, "Foods.json"));
        Food[] foodarr = JsonHelper.FromJson<Food>(text);
        foods = new List<Food>(foodarr);
        // Debug.Log(GetFoodByName("香蕉").name);
        // Debug.Log(text);
        // Debug.Log(foods);
        // Debug.Log(food.name);
        // Food[] foods = new Food[2];
        // foods[0] = new Food();
        // foods[0].name = "anson";
        // foods[1] = new Food();
        // foods[1].name = "anson2";

        // string playerToJson = JsonHelper.ToJson(foods, true);

        // File.WriteAllText("/Users/chiu/Desktop/Foods2.json", playerToJson);
        // string text = LoadJsonfile(Path.Combine("/Users/chiu/Desktop", "Foods2.json"));
        // Debug.Log(text);
        // Food[] foods_json = JsonHelper.FromJson<Food>(playerToJson);

        // Debug.Log(foods_json[0].name);
        // Debug.Log(foods_json[1].name);
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
}
