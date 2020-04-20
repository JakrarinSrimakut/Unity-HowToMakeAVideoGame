using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    //note: on Collision entry won't work if your collider is marked trigger need to use OnTriggerENter()
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
