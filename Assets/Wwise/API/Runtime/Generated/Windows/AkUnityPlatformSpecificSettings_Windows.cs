#if UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN || UNITY_WSA

//------------------------------------------------------------------------------

// <auto-generated />

//

// This file was automatically generated by SWIG (https://www.swig.org).

// Version 4.2.1

//

// Do not make changes to this file unless you know what you are doing - modify

// the SWIG interface file instead.

//------------------------------------------------------------------------------





public class AkUnityPlatformSpecificSettings : global::System.IDisposable {

  private global::System.IntPtr swigCPtr;

  protected bool swigCMemOwn;



  internal AkUnityPlatformSpecificSettings(global::System.IntPtr cPtr, bool cMemoryOwn) {

    swigCMemOwn = cMemoryOwn;

    swigCPtr = cPtr;

  }



  internal static global::System.IntPtr getCPtr(AkUnityPlatformSpecificSettings obj) {

    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

  }



  internal virtual void setCPtr(global::System.IntPtr cPtr) {

    Dispose();

    swigCPtr = cPtr;

  }



  ~AkUnityPlatformSpecificSettings() {

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

          AkSoundEnginePINVOKE.CSharp_delete_AkUnityPlatformSpecificSettings(swigCPtr);

        }

        swigCPtr = global::System.IntPtr.Zero;

      }

      global::System.GC.SuppressFinalize(this);

    }

  }



}

#endif // #if UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN || UNITY_WSA
