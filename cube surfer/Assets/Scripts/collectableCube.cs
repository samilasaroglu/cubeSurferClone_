using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableCube : MonoBehaviour
{

    [SerializeField] private bool isCollect;
    [SerializeField] private cubeCollecter cC;

    // Start is called before the first frame update
    void Start()
    {
        isCollect = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            this.transform.parent = null;
            cC.parentsCubeNum--;
           
            gameObject.GetComponent<BoxCollider>().enabled = false;


        }

        if (other.gameObject.tag == "lav")
        {


            this.transform.parent = null;

            gameObject.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(gameObject);
            cC.yukseklikAzalt();
            cC.parentsCubeNum--;

        }
        if (other.gameObject.tag == "bonus")
        {
            this.transform.parent = null;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<Collider>().enabled = false;

        }
    }

 

    public void setCollect()
    {
        isCollect = true;
    }

    public bool getIsCollect()
    {
        return isCollect;
    }

    public void destroyCollectableCube()
    {
        Destroy(this.gameObject); 
    }

   
}
