using UnityEngine;

public class ObstacleDropMovement : MonoBehaviour
{

    public float speed = 1f;
    public GameObject ground;

    private Vector3 pos1;
    private Vector3 pos2;

    public float max_y = 10f;
    public bool is_max_y = true;

    // Use this for initialization
    void Start()
    {
        if (is_max_y)
        {
            pos1 = new Vector3(transform.position.x, max_y, transform.position.z);
            pos2 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        else{
            pos1 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            pos2 = new Vector3(transform.position.x, max_y, transform.position.z);
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 2));
    }
}
