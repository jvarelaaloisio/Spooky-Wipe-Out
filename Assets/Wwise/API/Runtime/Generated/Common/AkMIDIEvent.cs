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





public class AkMIDIEvent : global::System.IDisposable {

  private global::System.IntPtr swigCPtr;

  protected bool swigCMemOwn;



  internal AkMIDIEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {

    swigCMemOwn = cMemoryOwn;

    swigCPtr = cPtr;

  }



  internal static global::System.IntPtr getCPtr(AkMIDIEvent obj) {

    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

  }



  internal virtual void setCPtr(global::System.IntPtr cPtr) {

    Dispose();

    swigCPtr = cPtr;

  }



  ~AkMIDIEvent() {

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

          AkSoundEnginePINVOKE.CSharp_delete_AkMIDIEvent(swigCPtr);

        }

        swigCPtr = global::System.IntPtr.Zero;

      }

      global::System.GC.SuppressFinalize(this);

    }

  }



  public byte byChan { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byChan_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byChan_get(swigCPtr); } 

  }



  public class tGen : global::System.IDisposable {

    private global::System.IntPtr swigCPtr;

    protected bool swigCMemOwn;

  

    internal tGen(global::System.IntPtr cPtr, bool cMemoryOwn) {

      swigCMemOwn = cMemoryOwn;

      swigCPtr = cPtr;

    }

  

    internal static global::System.IntPtr getCPtr(tGen obj) {

      return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

    }

  

    internal virtual void setCPtr(global::System.IntPtr cPtr) {

      Dispose();

      swigCPtr = cPtr;

    }

  

    ~tGen() {

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

            AkSoundEnginePINVOKE.CSharp_delete_AkMIDIEvent_tGen(swigCPtr);

          }

          swigCPtr = global::System.IntPtr.Zero;

        }

        global::System.GC.SuppressFinalize(this);

      }

    }

  

    public byte byParam1 { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tGen_byParam1_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tGen_byParam1_get(swigCPtr); } 

    }

  

    public byte byParam2 { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tGen_byParam2_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tGen_byParam2_get(swigCPtr); } 

    }

  

    public tGen() : this(AkSoundEnginePINVOKE.CSharp_new_AkMIDIEvent_tGen(), true) {

    }

  

  }



  public class tNoteOnOff : global::System.IDisposable {

    private global::System.IntPtr swigCPtr;

    protected bool swigCMemOwn;

  

    internal tNoteOnOff(global::System.IntPtr cPtr, bool cMemoryOwn) {

      swigCMemOwn = cMemoryOwn;

      swigCPtr = cPtr;

    }

  

    internal static global::System.IntPtr getCPtr(tNoteOnOff obj) {

      return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

    }

  

    internal virtual void setCPtr(global::System.IntPtr cPtr) {

      Dispose();

      swigCPtr = cPtr;

    }

  

    ~tNoteOnOff() {

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

            AkSoundEnginePINVOKE.CSharp_delete_AkMIDIEvent_tNoteOnOff(swigCPtr);

          }

          swigCPtr = global::System.IntPtr.Zero;

        }

        global::System.GC.SuppressFinalize(this);

      }

    }

  

    public byte byNote { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(swigCPtr); } 

    }

  

    public byte byVelocity { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(swigCPtr); } 

    }

  

    public tNoteOnOff() : this(AkSoundEnginePINVOKE.CSharp_new_AkMIDIEvent_tNoteOnOff(), true) {

    }

  

  }



  public class tCc : global::System.IDisposable {

    private global::System.IntPtr swigCPtr;

    protected bool swigCMemOwn;

  

    internal tCc(global::System.IntPtr cPtr, bool cMemoryOwn) {

      swigCMemOwn = cMemoryOwn;

      swigCPtr = cPtr;

    }

  

    internal static global::System.IntPtr getCPtr(tCc obj) {

      return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

    }

  

    internal virtual void setCPtr(global::System.IntPtr cPtr) {

      Dispose();

      swigCPtr = cPtr;

    }

  

    ~tCc() {

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

            AkSoundEnginePINVOKE.CSharp_delete_AkMIDIEvent_tCc(swigCPtr);

          }

          swigCPtr = global::System.IntPtr.Zero;

        }

        global::System.GC.SuppressFinalize(this);

      }

    }

  

    public byte byCc { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tCc_byCc_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tCc_byCc_get(swigCPtr); } 

    }

  

    public byte byValue { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tCc_byValue_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tCc_byValue_get(swigCPtr); } 

    }

  

    public tCc() : this(AkSoundEnginePINVOKE.CSharp_new_AkMIDIEvent_tCc(), true) {

    }

  

  }



  public class tPitchBend : global::System.IDisposable {

    private global::System.IntPtr swigCPtr;

    protected bool swigCMemOwn;

  

    internal tPitchBend(global::System.IntPtr cPtr, bool cMemoryOwn) {

      swigCMemOwn = cMemoryOwn;

      swigCPtr = cPtr;

    }

  

    internal static global::System.IntPtr getCPtr(tPitchBend obj) {

      return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

    }

  

    internal virtual void setCPtr(global::System.IntPtr cPtr) {

      Dispose();

      swigCPtr = cPtr;

    }

  

    ~tPitchBend() {

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

            AkSoundEnginePINVOKE.CSharp_delete_AkMIDIEvent_tPitchBend(swigCPtr);

          }

          swigCPtr = global::System.IntPtr.Zero;

        }

        global::System.GC.SuppressFinalize(this);

      }

    }

  

    public byte byValueLsb { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(swigCPtr); } 

    }

  

    public byte byValueMsb { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(swigCPtr); } 

    }

  

    public tPitchBend() : this(AkSoundEnginePINVOKE.CSharp_new_AkMIDIEvent_tPitchBend(), true) {

    }

  

  }



  public class tNoteAftertouch : global::System.IDisposable {

    private global::System.IntPtr swigCPtr;

    protected bool swigCMemOwn;

  

    internal tNoteAftertouch(global::System.IntPtr cPtr, bool cMemoryOwn) {

      swigCMemOwn = cMemoryOwn;

      swigCPtr = cPtr;

    }

  

    internal static global::System.IntPtr getCPtr(tNoteAftertouch obj) {

      return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

    }

  

    internal virtual void setCPtr(global::System.IntPtr cPtr) {

      Dispose();

      swigCPtr = cPtr;

    }

  

    ~tNoteAftertouch() {

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

            AkSoundEnginePINVOKE.CSharp_delete_AkMIDIEvent_tNoteAftertouch(swigCPtr);

          }

          swigCPtr = global::System.IntPtr.Zero;

        }

        global::System.GC.SuppressFinalize(this);

      }

    }

  

    public byte byNote { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(swigCPtr); } 

    }

  

    public byte byValue { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(swigCPtr); } 

    }

  

    public tNoteAftertouch() : this(AkSoundEnginePINVOKE.CSharp_new_AkMIDIEvent_tNoteAftertouch(), true) {

    }

  

  }



  public class tChanAftertouch : global::System.IDisposable {

    private global::System.IntPtr swigCPtr;

    protected bool swigCMemOwn;

  

    internal tChanAftertouch(global::System.IntPtr cPtr, bool cMemoryOwn) {

      swigCMemOwn = cMemoryOwn;

      swigCPtr = cPtr;

    }

  

    internal static global::System.IntPtr getCPtr(tChanAftertouch obj) {

      return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

    }

  

    internal virtual void setCPtr(global::System.IntPtr cPtr) {

      Dispose();

      swigCPtr = cPtr;

    }

  

    ~tChanAftertouch() {

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

            AkSoundEnginePINVOKE.CSharp_delete_AkMIDIEvent_tChanAftertouch(swigCPtr);

          }

          swigCPtr = global::System.IntPtr.Zero;

        }

        global::System.GC.SuppressFinalize(this);

      }

    }

  

    public byte byValue { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(swigCPtr); } 

    }

  

    public tChanAftertouch() : this(AkSoundEnginePINVOKE.CSharp_new_AkMIDIEvent_tChanAftertouch(), true) {

    }

  

  }



  public class tProgramChange : global::System.IDisposable {

    private global::System.IntPtr swigCPtr;

    protected bool swigCMemOwn;

  

    internal tProgramChange(global::System.IntPtr cPtr, bool cMemoryOwn) {

      swigCMemOwn = cMemoryOwn;

      swigCPtr = cPtr;

    }

  

    internal static global::System.IntPtr getCPtr(tProgramChange obj) {

      return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

    }

  

    internal virtual void setCPtr(global::System.IntPtr cPtr) {

      Dispose();

      swigCPtr = cPtr;

    }

  

    ~tProgramChange() {

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

            AkSoundEnginePINVOKE.CSharp_delete_AkMIDIEvent_tProgramChange(swigCPtr);

          }

          swigCPtr = global::System.IntPtr.Zero;

        }

        global::System.GC.SuppressFinalize(this);

      }

    }

  

    public byte byProgramNum { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(swigCPtr); } 

    }

  

    public tProgramChange() : this(AkSoundEnginePINVOKE.CSharp_new_AkMIDIEvent_tProgramChange(), true) {

    }

  

  }



  public class tWwiseCmd : global::System.IDisposable {

    private global::System.IntPtr swigCPtr;

    protected bool swigCMemOwn;

  

    internal tWwiseCmd(global::System.IntPtr cPtr, bool cMemoryOwn) {

      swigCMemOwn = cMemoryOwn;

      swigCPtr = cPtr;

    }

  

    internal static global::System.IntPtr getCPtr(tWwiseCmd obj) {

      return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;

    }

  

    internal virtual void setCPtr(global::System.IntPtr cPtr) {

      Dispose();

      swigCPtr = cPtr;

    }

  

    ~tWwiseCmd() {

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

            AkSoundEnginePINVOKE.CSharp_delete_AkMIDIEvent_tWwiseCmd(swigCPtr);

          }

          swigCPtr = global::System.IntPtr.Zero;

        }

        global::System.GC.SuppressFinalize(this);

      }

    }

  

    public ushort uCmd { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tWwiseCmd_uCmd_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tWwiseCmd_uCmd_get(swigCPtr); } 

    }

  

    public uint uArg { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tWwiseCmd_uArg_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_tWwiseCmd_uArg_get(swigCPtr); } 

    }

  

    public tWwiseCmd() : this(AkSoundEnginePINVOKE.CSharp_new_AkMIDIEvent_tWwiseCmd(), true) {

    }

  

  }



  public AkMIDIEvent.tGen Gen { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_Gen_set(swigCPtr, AkMIDIEvent.tGen.getCPtr(value)); } 

    get {

      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_Gen_get(swigCPtr);

      AkMIDIEvent.tGen ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkMIDIEvent.tGen(cPtr, false);

      return ret;

    } 

  }



  public AkMIDIEvent.tCc Cc { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_Cc_set(swigCPtr, AkMIDIEvent.tCc.getCPtr(value)); } 

    get {

      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_Cc_get(swigCPtr);

      AkMIDIEvent.tCc ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkMIDIEvent.tCc(cPtr, false);

      return ret;

    } 

  }



  public AkMIDIEvent.tNoteOnOff NoteOnOff { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_NoteOnOff_set(swigCPtr, AkMIDIEvent.tNoteOnOff.getCPtr(value)); } 

    get {

      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_NoteOnOff_get(swigCPtr);

      AkMIDIEvent.tNoteOnOff ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkMIDIEvent.tNoteOnOff(cPtr, false);

      return ret;

    } 

  }



  public AkMIDIEvent.tPitchBend PitchBend { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_PitchBend_set(swigCPtr, AkMIDIEvent.tPitchBend.getCPtr(value)); } 

    get {

      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_PitchBend_get(swigCPtr);

      AkMIDIEvent.tPitchBend ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkMIDIEvent.tPitchBend(cPtr, false);

      return ret;

    } 

  }



  public AkMIDIEvent.tNoteAftertouch NoteAftertouch { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_NoteAftertouch_set(swigCPtr, AkMIDIEvent.tNoteAftertouch.getCPtr(value)); } 

    get {

      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_NoteAftertouch_get(swigCPtr);

      AkMIDIEvent.tNoteAftertouch ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkMIDIEvent.tNoteAftertouch(cPtr, false);

      return ret;

    } 

  }



  public AkMIDIEvent.tChanAftertouch ChanAftertouch { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_ChanAftertouch_set(swigCPtr, AkMIDIEvent.tChanAftertouch.getCPtr(value)); } 

    get {

      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_ChanAftertouch_get(swigCPtr);

      AkMIDIEvent.tChanAftertouch ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkMIDIEvent.tChanAftertouch(cPtr, false);

      return ret;

    } 

  }



  public AkMIDIEvent.tProgramChange ProgramChange { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_ProgramChange_set(swigCPtr, AkMIDIEvent.tProgramChange.getCPtr(value)); } 

    get {

      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_ProgramChange_get(swigCPtr);

      AkMIDIEvent.tProgramChange ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkMIDIEvent.tProgramChange(cPtr, false);

      return ret;

    } 

  }



  public AkMIDIEvent.tWwiseCmd WwiseCmd { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_WwiseCmd_set(swigCPtr, AkMIDIEvent.tWwiseCmd.getCPtr(value)); } 

    get {

      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_WwiseCmd_get(swigCPtr);

      AkMIDIEvent.tWwiseCmd ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkMIDIEvent.tWwiseCmd(cPtr, false);

      return ret;

    } 

  }



  public AkMIDIEventTypes byType { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byType_set(swigCPtr, (int)value); }  get { return (AkMIDIEventTypes)AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byType_get(swigCPtr); } 

  }



  public byte byOnOffNote { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byOnOffNote_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byOnOffNote_get(swigCPtr); } 

  }



  public byte byVelocity { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byVelocity_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byVelocity_get(swigCPtr); } 

  }



  public AkMIDICcTypes byCc { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byCc_set(swigCPtr, (int)value); }  get { return (AkMIDICcTypes)AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byCc_get(swigCPtr); } 

  }



  public byte byCcValue { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byCcValue_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byCcValue_get(swigCPtr); } 

  }



  public byte byValueLsb { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byValueLsb_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byValueLsb_get(swigCPtr); } 

  }



  public byte byValueMsb { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byValueMsb_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byValueMsb_get(swigCPtr); } 

  }



  public byte byAftertouchNote { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byAftertouchNote_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byAftertouchNote_get(swigCPtr); } 

  }



  public byte byNoteAftertouchValue { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byNoteAftertouchValue_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byNoteAftertouchValue_get(swigCPtr); } 

  }



  public byte byChanAftertouchValue { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byChanAftertouchValue_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byChanAftertouchValue_get(swigCPtr); } 

  }



  public byte byProgramNum { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byProgramNum_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_byProgramNum_get(swigCPtr); } 

  }



  public ushort uCmd { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_uCmd_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_uCmd_get(swigCPtr); } 

  }



  public uint uArg { set { AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_uArg_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkMIDIEvent_uArg_get(swigCPtr); } 

  }



  public AkMIDIEvent() : this(AkSoundEnginePINVOKE.CSharp_new_AkMIDIEvent(), true) {

  }



}

#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
