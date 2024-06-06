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
		{ (Key.Digit0,  Key.Numpad0), 0 },
		{ (Key.Digit1,  Key.Numpad1), 1 },
		{ (Key.Digit2,  Key.Numpad2), 2 },
		{ (Key.Digit3,  Key.Numpad3), 3 },
		{ (Key.Digit4,  Key.Numpad4), 4 },
  		{ (Key.Digit5,  Key.Numpad5), 5 },
    		{ (Key.Digit6,  Key.Numpad6), 6 },
    		{ (Key.Digit7,  Key.Numpad7), 7 },
      		{ (Key.Digit8,  Key.Numpad8), 8 },
		{ (Key.Digit9,  Key.Numpad9), 9 }
	};

	public bool AllowDigitKeys { get; private set; }
	public bool AllowNumpadKeys { get; private set; } = true;

	public void Start()
	{
		ModHelper.Console.WriteLine($"Outer Wilds - Alter Time loaded.", MessageType.Success);
	}

	public override void Configure(IModConfig config)
	{
		AllowDigitKeys = config.GetSettingsValue<bool>("AllowDigitKeys");
		AllowNumpadKeys = config.GetSettingsValue<bool>("AllowNumpadKeys");
	}

	public void Update()
	{
		foreach (var val in timescales)
		{
			var digit = val.Key.key;
			var numpadKey = val.Key.numpadKey;
			var timescale = val.Value;

			if ((AllowDigitKeys && Keyboard.current[digit].wasReleasedThisFrame) || (AllowNumpadKeys && Keyboard.current[numpadKey].wasReleasedThisFrame))
			{
				Time.timeScale = timescale;
			}
		}
	}
}
