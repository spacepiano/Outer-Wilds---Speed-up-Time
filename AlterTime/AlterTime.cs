using OWML.Common;
using OWML.ModHelper;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace AlterTime;

public class AlterTime : ModBehaviour
{
	public Dictionary<(Key key, Key numpadKey), int> timescales = new()
	{
		{ (Key.Digit0, Key.Numpad0), 0 },
		{ (Key.Digit1, Key.Numpad1), 1 },
		{ (Key.Digit2, Key.Numpad2), 2 },
		{ (Key.Digit3, Key.Numpad3), 3 },
		{ (Key.Digit4, Key.Numpad4), 4 }
	};

	public void Start()
	{
		ModHelper.Console.WriteLine($"Outer Wilds - Alter Time loaded.", MessageType.Success);
	}

	public void Update()
	{
		foreach (var val in timescales)
		{
			var digit = val.Key.key;
			var numpadKey = val.Key.numpadKey;
			var timescale = val.Value;

			if (Keyboard.current[digit].wasReleasedThisFrame || Keyboard.current[numpadKey].wasReleasedThisFrame)
			{
				Time.timeScale = timescale;
			}
		}
	}
}
