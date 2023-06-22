using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMenuMusic : MonoBehaviour
{
    private void Awake() {
    GameObject[] musicObj = GameObject.FindGameObjectsWithTag("MainMenuMusic");
    Destroy(musicObj[0]);
  }
}
