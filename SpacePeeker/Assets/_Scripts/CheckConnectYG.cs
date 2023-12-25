using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class CheckConnectYG : MonoBehaviour
{
    private void OnEnable() => YandexGame.GetDataEvent += CheckSDK;
    private void OnDisable() => YandexGame.GetDataEvent -= CheckSDK;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(YandexGame.SDKEnabled);
        if (YandexGame.SDKEnabled == true)
        {
            CheckSDK();
        }
    }

    public void CheckSDK()
    {
        if (YandexGame.auth == true)
        {
            Debug.Log("User authorization is OK");
        }
        else
        {
            Debug.Log("User is not logged in");
            YandexGame.AuthDialog();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
