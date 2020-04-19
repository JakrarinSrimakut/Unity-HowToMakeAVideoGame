using UnityEngine;

public class Shoot : MonoBehaviour {

    private float timeBtwShots; //counter for time to shoot
    public float startTimeBtwShots; //amount of time to shoot

    public GameObject projectile;
    // Use this for initialization
    void Start()
    {
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);// bullet appear at enemy position w/ no rotation
            timeBtwShots = startTimeBtwShots;//reset counter
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
