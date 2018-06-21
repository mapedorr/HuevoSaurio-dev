using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	// ══════════════════════════════════════════════════════════════ PUBLICS ════
	public GameObject cardPrefab;
	public GameObject cardsHolderPanel;
	public Card cardNido;
	public Card cardHuevo;

	// ══════════════════════════════════════════════════════════════ METHODS ════
	void Start ()
	{
		if (cardPrefab)
		{
			GameObject cardNidoGO = Instantiate (cardPrefab, cardsHolderPanel.transform);
			CardDisplay cardDisplay = cardNidoGO.GetComponent<CardDisplay> ();
			cardDisplay.card = cardNido;

			GameObject cardHuevoGO = Instantiate (cardPrefab, cardsHolderPanel.transform);
			cardDisplay = cardHuevoGO.GetComponent<CardDisplay> ();
			cardDisplay.card = cardHuevo;
		}
	}
}