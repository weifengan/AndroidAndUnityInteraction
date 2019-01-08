package com.felixwee.androidnativeplugin;

import android.widget.Toast;
import java.text.SimpleDateFormat;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;

public class MainActivity extends UnityPlayerActivity {

    /**
     * 显示Android Toast
     * @param str
     */
    public  void ShowToast(String str){
        Toast.makeText(this,str,Toast.LENGTH_SHORT).show();
    }


    /**
     * 旋转Cube对象
     */
    public void RotateCube(){
        //调用CubeController对象上所挂脚本的RotateCube,参数为0.5
        UnityPlayer.UnitySendMessage("Cube","Rotate","0.5");
    }
}
