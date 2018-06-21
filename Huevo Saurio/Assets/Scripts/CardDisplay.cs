using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
	// ══════════════════════════════════════════════════════════════ PUBLICS ════
	public Card card;
	public Image illustrationImage;

	// ═══════════════════════════════════════════════════════════ PROPERTIES ════
	Image _cardImage;

	// ══════════════════════════════════════════════════════════════ METHODS ════
	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake ()
	{

	}

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start ()
	{
		illustrationImage.sprite = card.illustration;
		illustrationImage.preserveAspect = true;
	}

	public void Select ()
	{
		transform.localScale = transform.localScale * 0.8f;
	}
}