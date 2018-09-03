using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour {

    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.completeL1UI();
    }
}




