using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PnjParle : MonoBehaviour
{
    public Image zoneTexte;
    public string[] dialogues;
    [HideInInspector]
    public bool isSelected = false;
    private TextMeshProUGUI objetTexte;
    private int compteur = 0;

    public GameObject feedbackSelected;

    // Start is called before the first frame update
    void Start()
    {
        zoneTexte.gameObject.SetActive(true);
        objetTexte = zoneTexte.GetComponentInChildren<TextMeshProUGUI>();
        zoneTexte.gameObject.SetActive(false);
        if (feedbackSelected)
        {
            feedbackSelected.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isSelected)
        {
            Parle();
        }
    }

    void Parle()
    {
        if (compteur == 0)
        {
            zoneTexte.gameObject.SetActive(true);
        }

        if (compteur >= dialogues.Length)
        {
            compteur = 0;
            zoneTexte.gameObject.SetActive(false);
        }
        else
        {
            objetTexte.text = dialogues[compteur];
            compteur += 1;
        }

    }

    public void Select()
    {
        isSelected = true;
        if (feedbackSelected)
        {
            feedbackSelected.SetActive(true);
        }
    }

    public void Deselect()
    {
        compteur = 0;
        zoneTexte.gameObject.SetActive(false); 
        isSelected = false;
        if (feedbackSelected)
        {
            feedbackSelected.SetActive(false);
        }
    }

}
