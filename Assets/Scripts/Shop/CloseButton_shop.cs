using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseButton_shop : MonoBehaviour
{

    [Header("Shop Event")]
    [SerializeField] GameObject shopUI;
    [SerializeField] Button openShopButton;
    [SerializeField]Button closeShopButton;

    // Start is called before the first frame update
    void Start()
    {
        AddShopEvents();
    }

    void AddShopEvents ()
    {
        openShopButton.onClick.RemoveAllListeners();
        openShopButton.onClick.AddListener(OpenShop);

        closeShopButton.onClick.RemoveAllListeners();
        closeShopButton.onClick.AddListener(CloseShop);
    }

    void OpenShop ()
    {
        shopUI.SetActive(true);
    }

    void CloseShop()
    {
        shopUI.SetActive(false);
    
    
    }

}

