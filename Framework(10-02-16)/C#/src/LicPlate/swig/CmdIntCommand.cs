/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CmdIntCommand : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CmdIntCommand(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CmdIntCommand obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CmdIntCommand() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_CmdIntCommand(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public CmdIntCommand(SWIGTYPE_p_f_r_std__istream_r_std__ostream_r_JL_VisionLib_V3__VisLibCmdInt__void proc, VisLibCmdInt cInt) : this(VisionLabPINVOKE.new_CmdIntCommand(SWIGTYPE_p_f_r_std__istream_r_std__ostream_r_JL_VisionLib_V3__VisLibCmdInt__void.getCPtr(proc), VisLibCmdInt.getCPtr(cInt)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Execute(SWIGTYPE_p_std__istream arg0, SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.CmdIntCommand_Execute(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0), SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}