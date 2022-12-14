//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TomCpp {

public class Vector3Collection : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<MyVector3>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Vector3Collection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vector3Collection obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Vector3Collection() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SWIG_ExamplePINVOKE.delete_Vector3Collection(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Vector3Collection(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (MyVector3 element in c) {
      this.Add(element);
    }
  }

  public Vector3Collection(global::System.Collections.Generic.IEnumerable<MyVector3> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (MyVector3 element in c) {
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

  public MyVector3 this[int index]  {
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

  public void CopyTo(MyVector3[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(MyVector3[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, MyVector3[] array, int arrayIndex, int count)
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

  public MyVector3[] ToArray() {
    MyVector3[] array = new MyVector3[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<MyVector3> global::System.Collections.Generic.IEnumerable<MyVector3>.GetEnumerator() {
    return new Vector3CollectionEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new Vector3CollectionEnumerator(this);
  }

  public Vector3CollectionEnumerator GetEnumerator() {
    return new Vector3CollectionEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class Vector3CollectionEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<MyVector3>
  {
    private Vector3Collection collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public Vector3CollectionEnumerator(Vector3Collection collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public MyVector3 Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (MyVector3)currentObject;
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
    SWIG_ExamplePINVOKE.Vector3Collection_Clear(swigCPtr);
  }

  public void Add(MyVector3 x) {
    SWIG_ExamplePINVOKE.Vector3Collection_Add(swigCPtr, MyVector3.getCPtr(x));
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = SWIG_ExamplePINVOKE.Vector3Collection_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = SWIG_ExamplePINVOKE.Vector3Collection_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    SWIG_ExamplePINVOKE.Vector3Collection_reserve(swigCPtr, n);
  }

  public Vector3Collection() : this(SWIG_ExamplePINVOKE.new_Vector3Collection__SWIG_0(), true) {
  }

  public Vector3Collection(Vector3Collection other) : this(SWIG_ExamplePINVOKE.new_Vector3Collection__SWIG_1(Vector3Collection.getCPtr(other)), true) {
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector3Collection(int capacity) : this(SWIG_ExamplePINVOKE.new_Vector3Collection__SWIG_2(capacity), true) {
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
  }

  private MyVector3 getitemcopy(int index) {
    MyVector3 ret = new MyVector3(SWIG_ExamplePINVOKE.Vector3Collection_getitemcopy(swigCPtr, index), true);
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private MyVector3 getitem(int index) {
    MyVector3 ret = new MyVector3(SWIG_ExamplePINVOKE.Vector3Collection_getitem(swigCPtr, index), false);
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, MyVector3 val) {
    SWIG_ExamplePINVOKE.Vector3Collection_setitem(swigCPtr, index, MyVector3.getCPtr(val));
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(Vector3Collection values) {
    SWIG_ExamplePINVOKE.Vector3Collection_AddRange(swigCPtr, Vector3Collection.getCPtr(values));
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector3Collection GetRange(int index, int count) {
    global::System.IntPtr cPtr = SWIG_ExamplePINVOKE.Vector3Collection_GetRange(swigCPtr, index, count);
    Vector3Collection ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3Collection(cPtr, true);
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, MyVector3 x) {
    SWIG_ExamplePINVOKE.Vector3Collection_Insert(swigCPtr, index, MyVector3.getCPtr(x));
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, Vector3Collection values) {
    SWIG_ExamplePINVOKE.Vector3Collection_InsertRange(swigCPtr, index, Vector3Collection.getCPtr(values));
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    SWIG_ExamplePINVOKE.Vector3Collection_RemoveAt(swigCPtr, index);
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    SWIG_ExamplePINVOKE.Vector3Collection_RemoveRange(swigCPtr, index, count);
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
  }

  public static Vector3Collection Repeat(MyVector3 value, int count) {
    global::System.IntPtr cPtr = SWIG_ExamplePINVOKE.Vector3Collection_Repeat(MyVector3.getCPtr(value), count);
    Vector3Collection ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3Collection(cPtr, true);
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    SWIG_ExamplePINVOKE.Vector3Collection_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    SWIG_ExamplePINVOKE.Vector3Collection_Reverse__SWIG_1(swigCPtr, index, count);
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, Vector3Collection values) {
    SWIG_ExamplePINVOKE.Vector3Collection_SetRange(swigCPtr, index, Vector3Collection.getCPtr(values));
    if (SWIG_ExamplePINVOKE.SWIGPendingException.Pending) throw SWIG_ExamplePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
