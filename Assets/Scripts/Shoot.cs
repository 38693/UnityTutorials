using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    public float delay = 0.5f;
    public KeyCode shootKey = KeyCode.LeftControl;

    void Update()
    {
        if (Input.GetKeyDown(shootKey))
        {
            CallShot();
        }
    }

    public void CallShot()
    {
        StartCoroutine(AwaitDelay(delay));
    }

    private IEnumerator AwaitDelay(float time)
    {
        yield return new WaitForSeconds(time);
        createProjectile();
    }

    private void createProjectile()
    {
        GameObject ob = Instantiate(prefab);
        ob.transform.rotation = transform.rotation;
        ob.transform.position = transform.position + transform.forward;
        Destroy(ob, 3f);
    }
}