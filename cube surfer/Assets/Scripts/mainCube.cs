using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCube : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private UnityEngine.UI.Text oyunSonuText,toplamDiamondText;
    [SerializeField] private cubeCollecter cC;



    private void Start()
    {
        Time.timeScale = 1;
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            Time.timeScale = 0f;
            losePanel.SetActive(true);
        }
        else if (other.gameObject.tag == "lav")
        {
            Time.timeScale = 0f;
            losePanel.SetActive(true);

        }
        else if (other.gameObject.tag == "bonus")
        {
            Time.timeScale = 0f;
        }
        if (other.gameObject.name == "1x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 1X";
            toplamDiamondText.text = "" + cC.diamondSkor;
            


        }
        if (other.gameObject.name == "2x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 2X";
            toplamDiamondText.text = "" + cC.diamondSkor*2;

        }

        if (other.gameObject.name == "3x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 3X";
            toplamDiamondText.text = "" + cC.diamondSkor * 3;

        }
        if (other.gameObject.name == "4x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 4X";
            toplamDiamondText.text = "" + cC.diamondSkor * 4;

        }
        if (other.gameObject.name == "5x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 5X";
            toplamDiamondText.text = "" + cC.diamondSkor * 5;

        }
        if (other.gameObject.name == "6x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 6X";
            toplamDiamondText.text = "" + cC.diamondSkor * 6;

        }
        if (other.gameObject.name == "7x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 7X";
            toplamDiamondText.text = "" + cC.diamondSkor * 7;

        }
        if (other.gameObject.name == "8x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 8X";
            toplamDiamondText.text = "" + cC.diamondSkor * 8;

        }
        if (other.gameObject.name == "9x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 9X";
            toplamDiamondText.text = "" + cC.diamondSkor * 9;

        }
        if (other.gameObject.name == "10x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 10X";
            toplamDiamondText.text = "" + cC.diamondSkor * 10;

        }
        if (other.gameObject.name == "11x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 11X";
            toplamDiamondText.text = "" + cC.diamondSkor * 11;

        }
        if (other.gameObject.name == "12x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 12X";
            toplamDiamondText.text = "" + cC.diamondSkor * 12;

        }
        if (other.gameObject.name == "20x")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 20X";
            toplamDiamondText.text = "" + cC.diamondSkor * 20;

        }
        if (other.gameObject.tag == "Finish")
        {
            winPanel.SetActive(true);
            oyunSonuText.text = "GREAT! 20X";
            toplamDiamondText.text = "" + cC.diamondSkor * 20;

        }
    }
}
