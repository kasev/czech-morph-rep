//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ufal.MorphoDiTa {

public class TaggedLemmaForms : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TaggedLemmaForms(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TaggedLemmaForms obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TaggedLemmaForms() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          morphodita_csharpPINVOKE.delete_TaggedLemmaForms(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string lemma {
    set {
      morphodita_csharpPINVOKE.TaggedLemmaForms_lemma_set(swigCPtr, value);
      if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = morphodita_csharpPINVOKE.TaggedLemmaForms_lemma_get(swigCPtr);
      if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public TaggedForms forms {
    set {
      morphodita_csharpPINVOKE.TaggedLemmaForms_forms_set(swigCPtr, TaggedForms.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = morphodita_csharpPINVOKE.TaggedLemmaForms_forms_get(swigCPtr);
      TaggedForms ret = (cPtr == global::System.IntPtr.Zero) ? null : new TaggedForms(cPtr, false);
      return ret;
    } 
  }

  public TaggedLemmaForms() : this(morphodita_csharpPINVOKE.new_TaggedLemmaForms(), true) {
  }

}

}
