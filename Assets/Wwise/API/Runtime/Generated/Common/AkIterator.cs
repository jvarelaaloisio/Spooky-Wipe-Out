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





public class AkIterator : global::System.IDisposable {

  private global::System.IntPtr swigCPtr;

  protected bool swigCMemOwn;



  internal AkIterator(global::System.IntPtr cPtr, bool cMemoryOwn) {

    swigCMemOwn = cMemoryOwn;

    swigCPtr = cPtr;

  }



  internal static global::System.IntPtr getCPtr(AkIterator obj) {

    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

  }



  internal virtual void setCPtr(global::System.IntPtr cPtr) {

    Dispose();

    swigCPtr = cPtr;

  }



  ~AkIterator() {

    Dispose(false);

  }



  public void Dispose() {

    Dispose(true);

    global::System.GC.SuppressFinalize(this);

  }



  protected virtual void Dispose(bool disposing) {

    lock(this) {

      if (swigCPtr != global::System.IntPtr.Zero) {

        if (swigCMemOwn) {

          swigCMemOwn = false;

          AkSoundEnginePINVOKE.CSharp_delete_AkIterator(swigCPtr);

        }

        swigCPtr = global::System.IntPtr.Zero;

      }

      global::System.GC.SuppressFinalize(this);

    }

  }



  public AkPlaylistItem pItem { set { AkSoundEnginePINVOKE.CSharp_AkIterator_pItem_set(swigCPtr, AkPlaylistItem.getCPtr(value)); } 

    get {

      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkIterator_pItem_get(swigCPtr);

      AkPlaylistItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkPlaylistItem(cPtr, false);

      return ret;

    } 

  }



  public AkIterator NextIter() {

    AkIterator ret = new AkIterator(AkSoundEnginePINVOKE.CSharp_AkIterator_NextIter(swigCPtr), false);

    return ret;

  }



  public AkIterator PrevIter() {

    AkIterator ret = new AkIterator(AkSoundEnginePINVOKE.CSharp_AkIterator_PrevIter(swigCPtr), false);

    return ret;

  }



  public AkPlaylistItem GetItem() {

    AkPlaylistItem ret = new AkPlaylistItem(AkSoundEnginePINVOKE.CSharp_AkIterator_GetItem(swigCPtr), false);

    return ret;

  }



  public bool IsEqualTo(AkIterator in_rOp) { return AkSoundEnginePINVOKE.CSharp_AkIterator_IsEqualTo(swigCPtr, AkIterator.getCPtr(in_rOp)); }



  public bool IsDifferentFrom(AkIterator in_rOp) { return AkSoundEnginePINVOKE.CSharp_AkIterator_IsDifferentFrom(swigCPtr, AkIterator.getCPtr(in_rOp)); }



  public AkIterator() : this(AkSoundEnginePINVOKE.CSharp_new_AkIterator(), true) {

  }



}

#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
