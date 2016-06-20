/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class CamInstallCmd : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CamInstallCmd(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CamInstallCmd obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CamInstallCmd() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_CamInstallCmd(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public CamInstallCmd(SWIGTYPE_p_f_r_std__istream_r_std__ostream__p_JL_VisionLib_V3__CameraBase proc) : this(VisionLabPINVOKE.new_CamInstallCmd__SWIG_0(SWIGTYPE_p_f_r_std__istream_r_std__ostream__p_JL_VisionLib_V3__CameraBase.getCPtr(proc)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public CamInstallCmd() : this(VisionLabPINVOKE.new_CamInstallCmd__SWIG_1(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual CameraBase Execute(SWIGTYPE_p_std__istream arg0, SWIGTYPE_p_std__ostream os) {
    global::System.IntPtr cPtr = VisionLabPINVOKE.CamInstallCmd_Execute(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0), SWIGTYPE_p_std__ostream.getCPtr(os));
    CameraBase ret = (cPtr == global::System.IntPtr.Zero) ? null : new CameraBase(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}