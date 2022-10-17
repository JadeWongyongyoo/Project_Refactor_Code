using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Defective.JSON;
using UnityEngine;

public class LocalSwordDatabase : SwordDatabase
{
    [SerializeField] TextAsset jsonFile;

    public override void PrepareDatas()
    {
        var jsonObject = new JSONObject(jsonFile.text);
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
