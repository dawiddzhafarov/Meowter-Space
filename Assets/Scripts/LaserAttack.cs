using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAttack : MonoBehaviour
{
    
    public GameObject laser;
    private GameObject laserInstance;

    public float laserFireingTime;
    public float laserCooldown;
    
    // Start is called before the first frame update
    void Start()
    {
        laserInstance = Instantiate(laser,
            transform.position + new Vector3(-transform.localScale.x * 0.6f, 0), Quaternion.identity) as GameObject;
        StartCoroutine(LaserFireingTime());

    }

    // Update is called once per frame
    void Update()
    {
        MoveLaser();
    }
    private void MoveLaser() {
        var laserPosition = transform.position;
        laserPosition.x += -laserInstance.transform.localScale.x / 2 - transform.localScale.x * 1.1f;
        laserInstance.transform.position = laserPosition;
    }
    IEnumerator LaserFireingTime()
    {
        yield return new WaitForSeconds(laserFireingTime);
        laserInstance.SetActive(false);
        StartCoroutine(LaserCooldown());
    }
    IEnumerator LaserCooldown()
    {
        yield return new WaitForSeconds(laserCooldown);
        laserInstance.SetActive(true);
        StartCoroutine(LaserFireingTime());
    }

    private void OnDestroy() {
        Destroy(laserInstance);
    }
}
