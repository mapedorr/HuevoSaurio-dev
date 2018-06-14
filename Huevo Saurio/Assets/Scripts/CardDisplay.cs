using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
	// ══════════════════════════════════════════════════════════════ PUBLICS ════
	public Card card;
	public Image illustrationImage;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start ()
	{
		illustrationImage.sprite = card.illustration;
	}
}