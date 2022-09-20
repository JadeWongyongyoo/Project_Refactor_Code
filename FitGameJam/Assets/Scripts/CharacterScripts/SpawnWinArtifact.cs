using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWinArtifact : MonoBehaviour
{
    public List<GameObject> artifactList;
    public GameObject spawnPosition;
    public WinOrLose winorlose;
    public int whichItem;

    void Start()
    {
        winorlose = gameObject.GetComponent<WinOrLose>();
    }

    public void createWinArtifact()
    {
        whichItem = Random.Range(0, artifactList.Count);
        Vector2 randomSpawnPos = new Vector2(spawnPosition.transform.position.x, Random.Range(spawnPosition.transform.position.y - 3.5f, spawnPosition.transform.position.y - 0.5f));
        Instantiate(artifactList[whichItem], randomSpawnPos, spawnPosition.transform.rotation);
        winorlose.SetArtifact = false;
    }

}
