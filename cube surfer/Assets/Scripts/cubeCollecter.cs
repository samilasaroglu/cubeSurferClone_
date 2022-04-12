using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class cubeCollecter : MonoBehaviour
{

    private float yukseklik;
    [SerializeField] private GameObject Cubes;
    private Vector3 a, b;
    [SerializeField] private cameraRotator cR;
    [SerializeField] private GameObject turner,turner1;
     public int diamondSkor;
    [SerializeField] private UnityEngine.UI.Text diamondSkorText;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private UnityEngine.UI.Text oyunSonuText, toplamDiamondText;
    private bool bonusZamani;
    BoxCollider boxCollider;
    [SerializeField] private GameObject magnet;
    private bool isMagnetActive;
    private float f;
    public int parentsCubeNum;


    // Start is called before the first frame update
    void Start()
    {
        parentsCubeNum = 0;
        isMagnetActive = false;
        boxCollider = GetComponent<BoxCollider>();
        bonusZamani = false;
        diamondSkor = 0;
        yukseklik = 0.5f;
        turner = GameObject.FindWithTag("turnRight");
        turner1 = GameObject.FindWithTag("turnLeft");

    }

    // Update is called once per frame
    void Update()
    {
        
        diamondSkorText.text = ""+diamondSkor;
        Cubes.gameObject.transform.position = new Vector3(Cubes.transform.position.x, yukseklik, Cubes.transform.position.z);
        if (bonusZamani == false)
        {
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);

        }
      
        if (Time.time >= f+10 && isMagnetActive==true)
        {
            isMagnetActive = false;
            Destroy(magnet);
            boxCollider.size = new Vector3(1, 10, 1);
            boxCollider.center = new Vector3(0, 3.5f, 0);
        }

        
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cube" && other.gameObject.GetComponent<collectableCube>().getIsCollect()==false)
        {
            yukseklikArttir();
            parentsCubeNum++;
            other.gameObject.transform.parent = Cubes.transform;
            other.transform.localPosition = new Vector3(0, other.transform.position.y-yukseklik, 0);
            other.gameObject.GetComponent<collectableCube>().setCollect();
        }
        if (other.gameObject.tag == "diamond")
        {
            other.gameObject.transform.DOScale(new Vector3(0, 0, 0), .5f);
            diamondSkor++;
        }
        if (other.gameObject.tag=="turnRight")
        {
            Cubes.transform.DORotate(new Vector3(0, 90, 0), .5f, RotateMode.Fast);
            cR.GetComponent<cameraRotator>().SetRotateRight();
            turner.GetComponent<Collider>().enabled = false;
        }

        if (other.gameObject.tag == "turnLeft")
        {
            Cubes.transform.DORotate(new Vector3(0, -90, 0), .5f, RotateMode.Fast);
            cR.GetComponent<cameraRotator>().SetRotateLeft();
            turner1.GetComponent<Collider>().enabled = false;

        }

        if (other.gameObject.tag == "bonus")
        {
            bonusZamani = true;
            transform.localPosition = transform.localPosition + new Vector3(0, 1, 0);
        }

        if (other.gameObject.tag == "Finish")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 20X";
            toplamDiamondText.text = "" + diamondSkor * 20;
            Time.timeScale = 0;

        }
        if (other.gameObject.tag == "magnet")
        {
            isMagnetActive = true;
            
            other.gameObject.transform.position = new Vector3(transform.localPosition.x, 0.5f, transform.position.z - 2);
            other.gameObject.transform.Rotate(90, 0, 0);
            other.gameObject.transform.parent = transform;
            boxCollider.size = new Vector3(10, 10, 5);
            boxCollider.center = new Vector3(0, 3.5f, 2);
            f = Time.time;
           
 
        }



    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {

            yukseklikAzalt();
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

        }
        if (other.gameObject.tag == "lav")
        {

            other.gameObject.GetComponent<BoxCollider>().enabled = false;


        }

    }
    public void yukseklikAzalt()
    {
        yukseklik = yukseklik - 1;
    }

    public void yukseklikArttir()
    {
        yukseklik = yukseklik + 1;        
    }
}
