/*************************************
			
		CubeController 
		
   @desction:
   @author:felixwee
   @email:felixwee@163.com
   @website:www.felixwee.com
   @github:http://www.github.com/weifengan
  
***************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeController : MonoBehaviour {

    //把场景
    public Button btnCallAndroid;
	// Use this for initialization
	void Start () {
        btnCallAndroid.onClick.AddListener(delegate ()
        {
            AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
            //调用Android里的RotateCube函数，此函数在Android中调用了CubeController和人里的Rotate函数
            jo.Call("ShowToast","Unity调用了ShowToast显示的消息");

        });

    }
	
	// Update is called once per frame
	void Update () {

        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        //调用Android里的RotateCube函数，此函数在Android中调用了CubeController和人里的Rotate函数
        jo.Call("RotateCube");

    }


    public void Rotate(string value)
    {
        this.transform.Rotate(Vector3.up * float.Parse(value));
    }


   
}
