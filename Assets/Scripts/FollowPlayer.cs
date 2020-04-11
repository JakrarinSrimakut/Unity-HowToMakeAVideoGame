using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset; //Every frame the camera transform equal that of player
	}
}
