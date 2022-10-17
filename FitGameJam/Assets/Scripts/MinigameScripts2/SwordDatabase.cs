using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SwordDatabase : MonoBehaviour
{
    [SerializeField] protected List<SwordData> swordDataList = new List<SwordData>();
    protected SwordData defaultData;

    private void Awake()
    {
        PrepareDatas();
    }

    public abstract void PrepareDatas();

    public SwordData GetDefaultData()
    {
        return defaultData;
    }

    public SwordData GetSwordDataByName(string swordname)
    {
        foreach (var swordData in swordDataList)
        {
            if (swordname.Contains(swordData.swordname))
                return swordData;
        }

        return null;
    }
}
