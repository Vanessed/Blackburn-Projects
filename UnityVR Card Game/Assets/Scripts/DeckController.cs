using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DeckController : MonoBehaviour
{



    public int materialCount;
    private Material[] cardMaterials;
    public FileInfo[] materials;
    public int cards;
    private GameObject[] deck;
    public GameObject card;

    void Start()
    {
        cards = 6;
        GameObject[] deck = new GameObject[cards];

        System.IO.DirectoryInfo a = new DirectoryInfo("Assets/Resources/CardMaterials");

        materials = a.GetFiles("*.mat", SearchOption.AllDirectories);

        materialCount = materials.Length;

        cardMaterials = new Material[materialCount];

        for (int i = 0; i < cardMaterials.Length; i++)
        {
            cardMaterials[i] = Resources.Load<Material>("CardMaterials/" + materials[i].Name.Replace(".mat",""));
        }

        for (int i = 0; i < deck.Length; i++)
        {
            deck[i] = Instantiate(card, gameObject.transform);
            deck[i].name = "card" + i;
            deck[i].transform.position = deck[i].transform.position + new Vector3(.224f*i,0,0);
            deck[i].GetComponent<Renderer>().material = cardMaterials[Random.Range(0,3)];
        }
    }

    // Updat e is called once per frame
    void Update()
    {

    }
}