/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BPN_ImageOptimizer_Float : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BPN_ImageOptimizer_Float(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BPN_ImageOptimizer_Float obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BPN_ImageOptimizer_Float() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_BPN_ImageOptimizer_Float(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public BPN_ImageOptimizer_Float(int populationSize, int nrEpochs, double lowConfidence, ClassImageSet_Float trainCIS, ClassImageSet_Float evalCIS, int hidden1Low, int hidden1High, int hidden2Low, int hidden2High, double learnRateLow, double learnRateHigh, double momentumLow, double momentumHigh) : this(VisionLabPINVOKE.new_BPN_ImageOptimizer_Float(populationSize, nrEpochs, lowConfidence, ClassImageSet_Float.getCPtr(trainCIS), ClassImageSet_Float.getCPtr(evalCIS), hidden1Low, hidden1High, hidden2Low, hidden2High, learnRateLow, learnRateHigh, momentumLow, momentumHigh), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetImageType() {
    string ret = VisionLabPINVOKE.BPN_ImageOptimizer_Float_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Optimize(int nrGenerations, double minError, double deltaError, double microP, ref double error, ref int hidden1, ref int hidden2, ref double learnRate, ref double momentum) {
    int ret = VisionLabPINVOKE.BPN_ImageOptimizer_Float_Optimize(swigCPtr, nrGenerations, minError, deltaError, microP, ref error, ref hidden1, ref hidden2, ref learnRate, ref momentum);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
