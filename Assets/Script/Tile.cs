using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private bool built = false;
    private bool work = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (!built)
            {
                if (work)
                {
                    GameObject temp = Instantiate(GameManager.instance.getBuilding(), this.transform.position,this.transform.rotation);
                    Vector3 position = new Vector3(this.transform.position.x, this.transform.position.y + (temp.GetComponent<Collider>().bounds.size.y / 2), this.transform.position.z);
                    temp.transform.position = position;
                    built = true;
                    Debug.Log("New Build");
                }
            }
        }
    }
    private void OnMouseEnter()
    {
        work = true;
    }
    private void OnMouseExit()
    {
        work = false;
    }

}
