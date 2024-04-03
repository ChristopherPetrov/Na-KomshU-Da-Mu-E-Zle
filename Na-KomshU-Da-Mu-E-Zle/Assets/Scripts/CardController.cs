using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public Transform[] slotPos;
    public bool[] availableCardSlots;

    public Text deckSize;

    public void DrawCard()
    {
        if (deck.Count > 0)
        {
            Card randCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = slotPos[i].position;
                    deck.Remove(randCard); // there should be a counter
                    availableCardSlots[i] = false;
                    return;
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        availableCardSlots = new bool[slotPos.Count()];
        for(int i = 0; i < availableCardSlots.Length; i++)
        {
            availableCardSlots[i] = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        deckSize.text = deck.Count.ToString();
    }
}
