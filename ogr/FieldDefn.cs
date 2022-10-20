//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace OSGeo.OGR {

using global::System;
using global::System.Runtime.InteropServices;

public class FieldDefn : global::System.IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;

  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  public FieldDefn(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(FieldDefn obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  public static HandleRef getCPtrAndDisown(FieldDefn obj, object parent) {
    if (obj != null)
    {
      obj.swigCMemOwn = false;
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }
  public static HandleRef getCPtrAndSetReference(FieldDefn obj, object parent) {
    if (obj != null)
    {
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }

  ~FieldDefn() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrPINVOKE.delete_FieldDefn(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FieldDefn(string name_null_ok, FieldType field_type) : this(OgrPINVOKE.new_FieldDefn(name_null_ok, (int)field_type), true, null) {
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetName() {
        /* %typemap(csout) (const char *utf8_path) */
        IntPtr cPtr = OgrPINVOKE.FieldDefn_GetName(swigCPtr);
        string ret = Ogr.Utf8BytesToString(cPtr);
        
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
        return ret;
}

  public string GetNameRef() {
    string ret = OgrPINVOKE.FieldDefn_GetNameRef(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetName(string name) {
    OgrPINVOKE.FieldDefn_SetName(swigCPtr, name);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetAlternativeName() {
    string ret = OgrPINVOKE.FieldDefn_GetAlternativeName(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetAlternativeNameRef() {
    string ret = OgrPINVOKE.FieldDefn_GetAlternativeNameRef(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetAlternativeName(string alternativeName) {
    OgrPINVOKE.FieldDefn_SetAlternativeName(swigCPtr, alternativeName);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public FieldType GetFieldType() {
    FieldType ret = (FieldType)OgrPINVOKE.FieldDefn_GetFieldType(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetType(FieldType type) {
    OgrPINVOKE.FieldDefn_SetType(swigCPtr, (int)type);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public FieldSubType GetSubType() {
    FieldSubType ret = (FieldSubType)OgrPINVOKE.FieldDefn_GetSubType(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSubType(FieldSubType type) {
    OgrPINVOKE.FieldDefn_SetSubType(swigCPtr, (int)type);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public Justification GetJustify() {
    Justification ret = (Justification)OgrPINVOKE.FieldDefn_GetJustify(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetJustify(Justification justify) {
    OgrPINVOKE.FieldDefn_SetJustify(swigCPtr, (int)justify);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetWidth() {
    int ret = OgrPINVOKE.FieldDefn_GetWidth(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetWidth(int width) {
    OgrPINVOKE.FieldDefn_SetWidth(swigCPtr, width);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetPrecision() {
    int ret = OgrPINVOKE.FieldDefn_GetPrecision(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPrecision(int precision) {
    OgrPINVOKE.FieldDefn_SetPrecision(swigCPtr, precision);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetTypeName() {
    string ret = OgrPINVOKE.FieldDefn_GetTypeName(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetFieldTypeName(FieldType type) {
    string ret = OgrPINVOKE.FieldDefn_GetFieldTypeName(swigCPtr, (int)type);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IsIgnored() {
    int ret = OgrPINVOKE.FieldDefn_IsIgnored(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetIgnored(int bIgnored) {
    OgrPINVOKE.FieldDefn_SetIgnored(swigCPtr, bIgnored);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IsNullable() {
    int ret = OgrPINVOKE.FieldDefn_IsNullable(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetNullable(int bNullable) {
    OgrPINVOKE.FieldDefn_SetNullable(swigCPtr, bNullable);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IsUnique() {
    int ret = OgrPINVOKE.FieldDefn_IsUnique(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetUnique(int bUnique) {
    OgrPINVOKE.FieldDefn_SetUnique(swigCPtr, bUnique);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetDefault() {
    string ret = OgrPINVOKE.FieldDefn_GetDefault(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDefault(string pszValue) {
    OgrPINVOKE.FieldDefn_SetDefault(swigCPtr, pszValue);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IsDefaultDriverSpecific() {
    int ret = OgrPINVOKE.FieldDefn_IsDefaultDriverSpecific(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetDomainName() {
    string ret = OgrPINVOKE.FieldDefn_GetDomainName(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDomainName(string name) {
    OgrPINVOKE.FieldDefn_SetDomainName(swigCPtr, name);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
