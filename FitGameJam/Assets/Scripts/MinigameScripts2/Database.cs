using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
	/*
	[SerializeField] SwordDatabase swordDatabase;

	void OnTriggerStay(Collider other)
	{
		var matchedSwordData = swordDatabase.GetSwordDataByName(other.transform.name);
		if (matchedSwordData != null)
			ApplySwordDataToPlayer(matchedSwordData);
	}

	private static void ApplySwordDataToPlayer(SwordData swordData)
	{
		PlayerManager.Instance.damage = swordData.damage;
		PlayerManager.Instance.isOnTheNichirin = swordData.name == "Nichirin";
		PlayerManager.Instance.isOnTheBenisakura = swordData.name == "Benisakura";
		PlayerManager.Instance.isOnTheDerflinger = swordData.name == "Derflinger";
		PlayerManager.Instance.isOnTheBeamsaber = swordData.name == "Beamsaber";
		PlayerManager.Instance.isOnTheExcalibur = swordData.name == "Excalibur";
	}

	void OnTriggerExit(Collider collision)
	{
		ApplySwordDataToPlayer(swordDatabase.GetDefaultData());
	}
	*/
}
