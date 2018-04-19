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

public class TaggedLemmasForms : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<TaggedLemmaForms>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TaggedLemmasForms(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TaggedLemmasForms obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TaggedLemmasForms() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          morphodita_csharpPINVOKE.delete_TaggedLemmasForms(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TaggedLemmasForms(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (TaggedLemmaForms element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public TaggedLemmaForms this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(TaggedLemmaForms[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(TaggedLemmaForms[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, TaggedLemmaForms[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<TaggedLemmaForms> global::System.Collections.Generic.IEnumerable<TaggedLemmaForms>.GetEnumerator() {
    return new TaggedLemmasFormsEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new TaggedLemmasFormsEnumerator(this);
  }

  public TaggedLemmasFormsEnumerator GetEnumerator() {
    return new TaggedLemmasFormsEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class TaggedLemmasFormsEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<TaggedLemmaForms>
  {
    private TaggedLemmasForms collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public TaggedLemmasFormsEnumerator(TaggedLemmasForms collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public TaggedLemmaForms Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (TaggedLemmaForms)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    morphodita_csharpPINVOKE.TaggedLemmasForms_Clear(swigCPtr);
  }

  public void Add(TaggedLemmaForms x) {
    morphodita_csharpPINVOKE.TaggedLemmasForms_Add(swigCPtr, TaggedLemmaForms.getCPtr(x));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = morphodita_csharpPINVOKE.TaggedLemmasForms_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = morphodita_csharpPINVOKE.TaggedLemmasForms_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    morphodita_csharpPINVOKE.TaggedLemmasForms_reserve(swigCPtr, n);
  }

  public TaggedLemmasForms() : this(morphodita_csharpPINVOKE.new_TaggedLemmasForms__SWIG_0(), true) {
  }

  public TaggedLemmasForms(TaggedLemmasForms other) : this(morphodita_csharpPINVOKE.new_TaggedLemmasForms__SWIG_1(TaggedLemmasForms.getCPtr(other)), true) {
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public TaggedLemmasForms(int capacity) : this(morphodita_csharpPINVOKE.new_TaggedLemmasForms__SWIG_2(capacity), true) {
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private TaggedLemmaForms getitemcopy(int index) {
    TaggedLemmaForms ret = new TaggedLemmaForms(morphodita_csharpPINVOKE.TaggedLemmasForms_getitemcopy(swigCPtr, index), true);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private TaggedLemmaForms getitem(int index) {
    TaggedLemmaForms ret = new TaggedLemmaForms(morphodita_csharpPINVOKE.TaggedLemmasForms_getitem(swigCPtr, index), false);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, TaggedLemmaForms val) {
    morphodita_csharpPINVOKE.TaggedLemmasForms_setitem(swigCPtr, index, TaggedLemmaForms.getCPtr(val));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(TaggedLemmasForms values) {
    morphodita_csharpPINVOKE.TaggedLemmasForms_AddRange(swigCPtr, TaggedLemmasForms.getCPtr(values));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public TaggedLemmasForms GetRange(int index, int count) {
    global::System.IntPtr cPtr = morphodita_csharpPINVOKE.TaggedLemmasForms_GetRange(swigCPtr, index, count);
    TaggedLemmasForms ret = (cPtr == global::System.IntPtr.Zero) ? null : new TaggedLemmasForms(cPtr, true);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, TaggedLemmaForms x) {
    morphodita_csharpPINVOKE.TaggedLemmasForms_Insert(swigCPtr, index, TaggedLemmaForms.getCPtr(x));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, TaggedLemmasForms values) {
    morphodita_csharpPINVOKE.TaggedLemmasForms_InsertRange(swigCPtr, index, TaggedLemmasForms.getCPtr(values));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    morphodita_csharpPINVOKE.TaggedLemmasForms_RemoveAt(swigCPtr, index);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    morphodita_csharpPINVOKE.TaggedLemmasForms_RemoveRange(swigCPtr, index, count);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TaggedLemmasForms Repeat(TaggedLemmaForms value, int count) {
    global::System.IntPtr cPtr = morphodita_csharpPINVOKE.TaggedLemmasForms_Repeat(TaggedLemmaForms.getCPtr(value), count);
    TaggedLemmasForms ret = (cPtr == global::System.IntPtr.Zero) ? null : new TaggedLemmasForms(cPtr, true);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    morphodita_csharpPINVOKE.TaggedLemmasForms_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    morphodita_csharpPINVOKE.TaggedLemmasForms_Reverse__SWIG_1(swigCPtr, index, count);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, TaggedLemmasForms values) {
    morphodita_csharpPINVOKE.TaggedLemmasForms_SetRange(swigCPtr, index, TaggedLemmasForms.getCPtr(values));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}

}