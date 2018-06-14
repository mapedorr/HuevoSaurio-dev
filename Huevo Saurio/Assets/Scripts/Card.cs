using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New card", menuName = "Card")]
public class Card : ScriptableObject
{
	// ══════════════════════════════════════════════════════════════ PUBLICS ════
	public new string name;
	public int number;
	public Sprite illustration;

	// ══════════════════════════════════════════════════════════════ METHODS ════
	// TODO: define methods
}