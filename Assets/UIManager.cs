using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   [SerializeField] private GameObject mainPage;
   [SerializeField] private GameObject settingPage;
   [SerializeField] private GameObject addingPage;

   public void SetActiveMainPage(bool status)
   {
        if(mainPage != null)
        {
            mainPage.SetActive(status);
        }
   }
   public void SetActiveSettingPage(bool status)
   {
        if(settingPage != null)
        {
            settingPage.SetActive(status);
        }
   }
   public void SetActiveAddingPage(bool status)
   {
        if(addingPage != null)
        {
            addingPage.SetActive(status);
        }
   }
}
