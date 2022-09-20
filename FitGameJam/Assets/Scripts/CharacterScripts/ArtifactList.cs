using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactList : MonoBehaviour
{
    public WinOrLose winorlose;
    SpawnWinArtifact spawnWinArtifact;

    // Start is called before the first frame update
    void Start()
    {
        spawnWinArtifact = GetComponent<SpawnWinArtifact>();
        winorlose = gameObject.GetComponent<WinOrLose>();
    }

    // Update is called once per frame
    void Update()
    {
        if (winorlose.SetArtifact == true)
        {
            spawnWinArtifact.createWinArtifact();
        }
    }

}
