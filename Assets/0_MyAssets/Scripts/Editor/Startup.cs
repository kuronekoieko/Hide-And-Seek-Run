using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


/// <summary>
/// https://docs.unity3d.com/ja/2018.4/Manual/RunningEditorCodeOnLaunch.html
/// Unityがロードされたとき、およびスクリプトが再コンパイルされたときに呼ばれる
/// </summary>
[InitializeOnLoad]
public class Startup
{
    static Startup()
    {
        // Debug.Log("Up and running");
        SetPlayerSettings();
        InputKeystore();
    }

    static void SetPlayerSettings()
    {
        if (PlayerSettings.bundleVersion != "0.1") return;

        // 共通 -----------------------------------------------
        PlayerSettings.defaultInterfaceOrientation = UIOrientation.Portrait;
        PlayerSettings.bundleVersion = "1.0";
        PlayerSettings.muteOtherAudioSources = false;

        // Android --------------------------------------------
        // 64bit対応
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.Android, ScriptingImplementation.IL2CPP);
        PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;
        PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel29;
        PlayerSettings.Android.bundleVersionCode = 1;

        // 変更の自動保存
        AssetDatabase.SaveAssets();
        Debug.Log("Changed PlayerSettings");
    }

    /// <summary>
    /// Unity5 Android Build keystore 自動入力
    /// http://yasuaki-ohama.hatenablog.com/entry/2015/12/23/213956
    /// </summary>
    static void InputKeystore()
    {
        //エイリアス名
        PlayerSettings.Android.keyaliasName = "ieko0305";
        // パスワードの再設定
        PlayerSettings.Android.keystorePass = "ieko0305";
        // パスワードの再設定
        PlayerSettings.Android.keyaliasPass = "ieko0305";
    }
}
