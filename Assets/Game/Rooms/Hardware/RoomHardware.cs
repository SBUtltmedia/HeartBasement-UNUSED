using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class RoomHardware : RoomScript<RoomHardware>
{


	IEnumerator OnInteractHotspotDoor( IHotspot hotspot )
	{
		if (Globals.m_progressExample == eProgress.None) {
		
			if (I.BilgePump.Owned){
			
				yield return C.Dave.Say("Let's take this back home and see how it works!");
				C.Dave.ChangeRoomBG(R.Map);
			} else {
				yield return C.Dave.Say("I need to buy a pump.");
			}
		} else {
			C.Dave.ChangeRoomBG(R.Map);
		}
			
		yield return E.Break;
	}

	void OnEnterRoom()
	{
		C.Dave.Position = Point("HWDoorPosition");
		C.HardwareClerk.Position = Point("HWClerkPosition");
		
		// Globals.m_progressExample = eProgress.TriedPump1;
		
		
		if(Globals.m_progressExample == eProgress.TriedPump1)
		{
			C.Neighbor1.Visible=true;
			C.Neighbor2.Visible=true;
			C.Neighbor1.Clickable=true;
			C.Neighbor2.Clickable=true;
		}
		else {
			C.Neighbor1.Visible=false;
			C.Neighbor2.Visible=false;
			C.Neighbor1.Clickable=false;
			C.Neighbor2.Clickable=false;
		}
	}

	IEnumerator OnEnterRoomAfterFade()
	{

		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotDoor( IHotspot hotspot )
	{

		yield return E.Break;
	}

	IEnumerator OnLookAtCharacterDave( ICharacter character )
	{

		yield return E.Break;
	}

	IEnumerator OnLookAtCharacterHardwareClerk( ICharacter character )
	{
		
		
		yield return E.Break;
	}

	IEnumerator OnInteractPropBeerPack( IProp prop )
	{
		I.Beer.Add();
		Prop("BeerPack").Disable();
		
		yield return C.Display(" Beer has been added to your inventory.");
		
		yield return E.Break;
	}
}