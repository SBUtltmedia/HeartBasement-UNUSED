using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class DialogBuyOptions : DialogTreeScript<DialogBuyOptions>
{
	public IEnumerator OnStart()
	{
		D.BuyOptions.OptionOff(2);
		D.BuyOptions.OptionOff(4);
		
		yield return E.ConsumeEvent;
	}

	public IEnumerator OnStop()
	{
		yield return E.Break;
	}

	IEnumerator Option1( IDialogOption option )
	{
			yield return C.Dave.Say("I'll take a medium handle.", 21);
			yield return E.WaitSkip();
			I.MediumHandle.Add();
			yield return C.Display("Medium Handle added to  your inventory.", 13);
			yield return E.WaitSkip();
			yield return C.HardwareClerk.Say("Anything else?", 5);
			D.BuyOptions.OptionOffForever(1);
			Stop();
			D.BuyOptions.Start();
		
		
		yield return E.Break;
	}

	IEnumerator Option2( IDialogOption option )
	{
			yield return C.Dave.Say("I'll take a large handle.", 22);
			yield return E.WaitSkip();
			I.LargeHandle.Add();
			yield return C.Display("Large Handle added to  your inventory.", 14);
			yield return E.WaitSkip();
			yield return C.HardwareClerk.Say("Anything else?", 6);
			D.BuyOptions.OptionOffForever(2);
			Stop();
			D.BuyOptions.Start();
		
		yield return E.Break;
	}

	IEnumerator Option5( IDialogOption option )
	{
		Stop();
		
		yield return E.Break;
	}

	IEnumerator Option3( IDialogOption option )
	{
			yield return C.Dave.Say("I'll take a medium diameter hose.", 23);
			yield return E.WaitSkip();
			I.MediumHose.Add();
			yield return C.Display("Medium Hose added to  your inventory.", 15);
			yield return E.WaitSkip();
			yield return C.HardwareClerk.Say("Anything else?", 7);
			D.BuyOptions.OptionOffForever(3);
			Stop();
			D.BuyOptions.Start();
		
		
		yield return E.Break;
	}

	IEnumerator Option4( IDialogOption option )
	{
			yield return C.Dave.Say("I'll take a large diameter hose.", 24);
			yield return E.WaitSkip();
			I.LargeHose.Add();
			yield return C.Display("Large Hose added to  your inventory.", 16);
			yield return E.WaitSkip();
			yield return C.HardwareClerk.Say("Anything else?", 8);
			D.BuyOptions.OptionOffForever(4);
			Stop();
			D.BuyOptions.Start();
		
		
		yield return E.Break;
	}

	IEnumerator Option6( IDialogOption option )
	{
		yield return C.Dave.Say(" Do you have any larger options?");
		
		yield return C.HardwareClerk.Say("Nope.");
		yield return E.WaitSkip();
		yield return E.WaitSkip();
		yield return C.Dave.Say("Can you check the back?");
		
		yield return C.HardwareClerk.Say("Alright, alright, you got me. These are the biggest handles and hoses we have in stock.");
		
		D.DialogWithClerk.OptionOffForever(6);
		D.DialogWithClerk.OptionOn(2);
		D.DialogWithClerk.OptionOn(4);
		
		Stop();
		D.BuyOptions.Start();
		yield return E.Break;
	}
}