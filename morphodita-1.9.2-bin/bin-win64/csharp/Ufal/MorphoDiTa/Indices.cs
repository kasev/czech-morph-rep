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

public class Indices : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<int>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Indices(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Indices obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Indices() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          morphodita_csharpPINVOKE.delete_Indices(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Indices(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (int element in c) {
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

  public int this[int index]  {
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

  public void CopyTo(int[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(int[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, int[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<int> global::System.Collections.Generic.IEnumerable<int>.GetEnumerator() {
    return new IndicesEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new IndicesEnumerator(this);
  }

  public IndicesEnumerator GetEnumerator() {
    return new IndicesEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class IndicesEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<int>
  {
    private Indices collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public IndicesEnumerator(Indices collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public int Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (int)currentObject;
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
    morphodita_csharpPINVOKE.Indices_Clear(swigCPtr);
  }

  public void Add(int x) {
    morphodita_csharpPINVOKE.Indices_Add(swigCPtr, x);
  }

  private uint size() {
    uint ret = morphodita_csharpPINVOKE.Indices_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = morphodita_csharpPINVOKE.Indices_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    morphodita_csharpPINVOKE.Indices_reserve(swigCPtr, n);
  }

  public Indices() : this(morphodita_csharpPINVOKE.new_Indices__SWIG_0(), true) {
  }

  public Indices(Indices other) : this(morphodita_csharpPINVOKE.new_Indices__SWIG_1(Indices.getCPtr(other)), true) {
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public Indices(int capacity) : this(morphodita_csharpPINVOKE.new_Indices__SWIG_2(capacity), true) {
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private int getitemcopy(int index) {
    int ret = morphodita_csharpPINVOKE.Indices_getitemcopy(swigCPtr, index);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private int getitem(int index) {
    int ret = morphodita_csharpPINVOKE.Indices_getitem(swigCPtr, index);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, int val) {
    morphodita_csharpPINVOKE.Indices_setitem(swigCPtr, index, val);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(Indices values) {
    morphodita_csharpPINVOKE.Indices_AddRange(swigCPtr, Indices.getCPtr(values));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public Indices GetRange(int index, int count) {
    global::System.IntPtr cPtr = morphodita_csharpPINVOKE.Indices_GetRange(swigCPtr, index, count);
    Indices ret = (cPtr == global::System.IntPtr.Zero) ? null : new Indices(cPtr, true);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, int x) {
    morphodita_csharpPINVOKE.Indices_Insert(swigCPtr, index, x);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, Indices values) {
    morphodita_csharpPINVOKE.Indices_InsertRange(swigCPtr, index, Indices.getCPtr(values));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    morphodita_csharpPINVOKE.Indices_RemoveAt(swigCPtr, index);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    morphodita_csharpPINVOKE.Indices_RemoveRange(swigCPtr, index, count);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Indices Repeat(int value, int count) {
    global::System.IntPtr cPtr = morphodita_csharpPINVOKE.Indices_Repeat(value, count);
    Indices ret = (cPtr == global::System.IntPtr.Zero) ? null : new Indices(cPtr, true);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    morphodita_csharpPINVOKE.Indices_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    morphodita_csharpPINVOKE.Indices_Reverse__SWIG_1(swigCPtr, index, count);
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, Indices values) {
    morphodita_csharpPINVOKE.Indices_SetRange(swigCPtr, index, Indices.getCPtr(values));
    if (morphodita_csharpPINVOKE.SWIGPendingException.Pending) throw morphodita_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(int value) {
    bool ret = morphodita_csharpPINVOKE.Indices_Contains(swigCPtr, value);
    return ret;
  }

  public int IndexOf(int value) {
    int ret = morphodita_csharpPINVOKE.Indices_IndexOf(swigCPtr, value);
    return ret;
  }

  public int LastIndexOf(int value) {
    int ret = morphodita_csharpPINVOKE.Indices_LastIndexOf(swigCPtr, value);
    return ret;
  }

  public bool Remove(int value) {
    bool ret = morphodita_csharpPINVOKE.Indices_Remove(swigCPtr, value);
    return ret;
  }

}

}