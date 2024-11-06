#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.

//------------------------------------------------------------------------------

// <auto-generated />

//

// This file was automatically generated by SWIG (https://www.swig.org).

// Version 4.2.1

//

// Do not make changes to this file unless you know what you are doing - modify

// the SWIG interface file instead.

//------------------------------------------------------------------------------





public class AkMarkerCallbackInfo : AkEventCallbackInfo {

  private global::System.IntPtr swigCPtr;



  internal AkMarkerCallbackInfo(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AkSoundEnginePINVOKE.CSharp_AkMarkerCallbackInfo_SWIGUpcast(cPtr), cMemoryOwn) {

    swigCPtr = cPtr;

  }



  internal static global::System.IntPtr getCPtr(AkMarkerCallbackInfo obj) {

    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

  }



  internal override void setCPtr(global::System.IntPtr cPtr) {

    base.setCPtr(AkSoundEnginePINVOKE.CSharp_AkMarkerCallbackInfo_SWIGUpcast(cPtr));

    swigCPtr = cPtr;

  }



  protected override void Dispose(bool disposing) {

    lock(this) {

      if (swigCPtr != global::System.IntPtr.Zero) {

        if (swigCMemOwn) {

          swigCMemOwn = false;

          AkSoundEnginePINVOKE.CSharp_delete_AkMarkerCallbackInfo(swigCPtr);

        }

        swigCPtr = global::System.IntPtr.Zero;

      }

      global::System.GC.SuppressFinalize(this);

      base.Dispose(disposing);

    }

  }



  public uint uIdentifier { get { return AkSoundEnginePINVOKE.CSharp_AkMarkerCallbackInfo_uIdentifier_get(swigCPtr); } 

  }



  public uint uPosition { get { return AkSoundEnginePINVOKE.CSharp_AkMarkerCallbackInfo_uPosition_get(swigCPtr); } 

  }



  public string strLabel { get { return AkSoundEngine.StringFromIntPtrString(AkSoundEnginePINVOKE.CSharp_AkMarkerCallbackInfo_strLabel_get(swigCPtr)); } 

  }



  public AkMarkerCallbackInfo() : this(AkSoundEnginePINVOKE.CSharp_new_AkMarkerCallbackInfo(), true) {

  }



}

#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
