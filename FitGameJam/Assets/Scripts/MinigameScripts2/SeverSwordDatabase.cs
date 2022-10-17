using System.Collections;
using System.Collections.Generic;
using Defective.JSON;
using UnityEngine.Networking;
using System;

public class SeverSwordDatabase : SwordDatabase
{
    [SerializeField] string url;
   
    public override void PrepareDatas()
    {
        StartCoroutine(DownloadswordDatabase());
    }

    IEnumerator DownloadswordDatabase()
    {
        var webRequest = UnityWebQuest.Get(url);
        yield return webRequest.SendWebRequest();

        var downloadedText = webRequest.downloadedHandler.text;
        var jsonObject = new JSONObject(downloadedText);
        foreach (var json in jsonObject.list)
        {
            var swordname = "";
            json.GetField(ref swordname, "swordname");

            var damage = 0;
            json.GetField(ref damage, "damage");

            var newSwordData = new SwordData();
            newSwordData.swordname = swordname;
            newSwordData.damage = damage;

            swordDataList.Add(newSwordData);
        }        
    }
}
