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

public class TaggedLemmas : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<TaggedLemma>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TaggedLemmas(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TaggedLemmas obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TaggedLemmas() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          morphodita_csharpPINVOKE.delete_TaggedLemmas(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TaggedLemmas(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (TaggedLemma element in c) {
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

  public TaggedLemma this[int index]  {
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

  public void CopyTo(TaggedLemma[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(TaggedLemma[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, TaggedLemma[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<TaggedLemma> global::System.Collections.Generic.IEnumerable<TaggedLemma>.GetEnumerator() {
    return new TaggedLemmasEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new TaggedLemmasEnumerator(this);
  }

  public TaggedLemmasEnumerator GetEnumerator() {
    return new TaggedLemmasEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class TaggedLemmasEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<TaggedLemma>
  {
    private TaggedLemmas collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public TaggedLemmasEnumerator(TaggedLemmas collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public TaggedLemma Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (TaggedLemma)currentObject;
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
    morphodita_csharpPINVOKE.TaggedLemmas_Clear(swigCPtr);
  }

  public void Add(TaggedLemma x) {
    morphodita_csharpPINVOKE.TaggedLemmas_Add(swigCPtr, TaggedLemma.getCPtr(x));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = morphodita_csharpPINVOKE.TaggedLemmas_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = morphodita_csharpPINVOKE.TaggedLemmas_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    morphodita_csharpPINVOKE.TaggedLemmas_reserve(swigCPtr, n);
  }

  public TaggedLemmas() : this(morphodita_csharpPINVOKE.new_TaggedLemmas__SWIG_0(), true) {
  }

  public TaggedLemmas(TaggedLemmas other) : this(morphodita_csharpPINVOKE.new_TaggedLemmas__SWIG_1(TaggedLemmas.getCPtr(other)), true) {
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public TaggedLemmas(int capacity) : this(morphodita_csharpPINVOKE.new_TaggedLemmas__SWIG_2(capacity), true) {
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private TaggedLemma getitemcopy(int index) {
    TaggedLemma ret = new TaggedLemma(morphodita_csharpPINVOKE.TaggedLemmas_getitemcopy(swigCPtr, index), true);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private TaggedLemma getitem(int index) {
    TaggedLemma ret = new TaggedLemma(morphodita_csharpPINVOKE.TaggedLemmas_getitem(swigCPtr, index), false);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, TaggedLemma val) {
    morphodita_csharpPINVOKE.TaggedLemmas_setitem(swigCPtr, index, TaggedLemma.getCPtr(val));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(TaggedLemmas values) {
    morphodita_csharpPINVOKE.TaggedLemmas_AddRange(swigCPtr, TaggedLemmas.getCPtr(values));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public TaggedLemmas GetRange(int index, int count) {
    global::System.IntPtr cPtr = morphodita_csharpPINVOKE.TaggedLemmas_GetRange(swigCPtr, index, count);
    TaggedLemmas ret = (cPtr == global::System.IntPtr.Zero) ? null : new TaggedLemmas(cPtr, true);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, TaggedLemma x) {
    morphodita_csharpPINVOKE.TaggedLemmas_Insert(swigCPtr, index, TaggedLemma.getCPtr(x));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, TaggedLemmas values) {
    morphodita_csharpPINVOKE.TaggedLemmas_InsertRange(swigCPtr, index, TaggedLemmas.getCPtr(values));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    morphodita_csharpPINVOKE.TaggedLemmas_RemoveAt(swigCPtr, index);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    morphodita_csharpPINVOKE.TaggedLemmas_RemoveRange(swigCPtr, index, count);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TaggedLemmas Repeat(TaggedLemma value, int count) {
    global::System.IntPtr cPtr = morphodita_csharpPINVOKE.TaggedLemmas_Repeat(TaggedLemma.getCPtr(value), count);
    TaggedLemmas ret = (cPtr == global::System.IntPtr.Zero) ? null : new TaggedLemmas(cPtr, true);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    morphodita_csharpPINVOKE.TaggedLemmas_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    morphodita_csharpPINVOKE.TaggedLemmas_Reverse__SWIG_1(swigCPtr, index, count);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, TaggedLemmas values) {
    morphodita_csharpPINVOKE.TaggedLemmas_SetRange(swigCPtr, index, TaggedLemmas.getCPtr(values));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}

}