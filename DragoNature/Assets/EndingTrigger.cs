﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")){
            EndGame();
        }
    }
    public void EndGame(){
        SceneManager.LoadScene("FinalScene");
    }
}
