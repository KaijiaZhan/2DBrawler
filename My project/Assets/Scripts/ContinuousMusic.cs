using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousMusic : MonoBehaviour
{
  public int gameStartScene;
  private void Awake() {
    GameObject[] musicObj = GameObject.FindGameObjectsWithTag("MainMenuMusic");
    if (musicObj.Length > 1 || gameStartScene == 1) {
        Destroy(this.gameObject);
    }
    DontDestroyOnLoad(this.gameObject);
  }
}
