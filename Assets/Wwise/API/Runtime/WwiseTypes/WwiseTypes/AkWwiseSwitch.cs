/*******************************************************************************

The content of this file includes portions of the proprietary AUDIOKINETIC Wwise

Technology released in source code form as part of the game integration package.

The content of this file may not be used without valid licenses to the

AUDIOKINETIC Wwise Technology.

Note that the use of the game engine is subject to the Unity(R) Terms of

Service at https://unity3d.com/legal/terms-of-service

 

License Usage

 

Licensees holding valid licenses to the AUDIOKINETIC Wwise Technology may use

this file in accordance with the end user license agreement provided with the

software or, alternatively, in accordance with the terms contained

in a written agreement between you and Audiokinetic Inc.

Copyright (c) 2024 Audiokinetic Inc.

*******************************************************************************/



#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.



namespace AK.Wwise

{

	[System.Serializable]

	///@brief This type can be used to set Switch values on gameobjects.

	public class Switch : BaseGroupType

	{

		public WwiseSwitchReference WwiseObjectReference;



		public override WwiseObjectReference ObjectReference

		{

			get { return WwiseObjectReference; }

			set { WwiseObjectReference = value as WwiseSwitchReference; }

		}



		public override WwiseObjectType WwiseObjectType { get { return WwiseObjectType.Switch; } }

		public override WwiseObjectType WwiseObjectGroupType { get { return WwiseObjectType.SwitchGroup; } }



		public void SetValue(UnityEngine.GameObject gameObject)

		{

			if (IsValid())

			{

				var result = AkSoundEngine.SetSwitch(GroupId, Id, gameObject);

				Verify(result);

			}

		}

	}

}

#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
