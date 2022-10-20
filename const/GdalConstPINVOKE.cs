//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace OSGeo.GDAL {

using global::System;
using global::System.Runtime.InteropServices;

class GdalConstPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="SWIGRegisterExceptionCallbacks_GdalConst")]
    public static extern void SWIGRegisterExceptionCallbacks_GdalConst(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_GdalConst")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_GdalConst(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_GdalConst(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_GdalConst(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;
    private static global::System.Object exceptionsLock = null;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(exceptionsLock) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(exceptionsLock) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }

    static SWIGPendingException() {
      exceptionsLock = new global::System.Object();
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="SWIGRegisterStringCallback_GdalConst")]
    public static extern void SWIGRegisterStringCallback_GdalConst(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_GdalConst(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static GdalConstPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_Unknown_get___")]
  public static extern int GDT_Unknown_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_Byte_get___")]
  public static extern int GDT_Byte_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_UInt16_get___")]
  public static extern int GDT_UInt16_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_Int16_get___")]
  public static extern int GDT_Int16_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_UInt32_get___")]
  public static extern int GDT_UInt32_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_Int32_get___")]
  public static extern int GDT_Int32_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_UInt64_get___")]
  public static extern int GDT_UInt64_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_Int64_get___")]
  public static extern int GDT_Int64_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_Float32_get___")]
  public static extern int GDT_Float32_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_Float64_get___")]
  public static extern int GDT_Float64_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_CInt16_get___")]
  public static extern int GDT_CInt16_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_CInt32_get___")]
  public static extern int GDT_CInt32_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_CFloat32_get___")]
  public static extern int GDT_CFloat32_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_CFloat64_get___")]
  public static extern int GDT_CFloat64_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDT_TypeCount_get___")]
  public static extern int GDT_TypeCount_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GA_ReadOnly_get___")]
  public static extern int GA_ReadOnly_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GA_Update_get___")]
  public static extern int GA_Update_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GF_Read_get___")]
  public static extern int GF_Read_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GF_Write_get___")]
  public static extern int GF_Write_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRIORA_NearestNeighbour_get___")]
  public static extern int GRIORA_NearestNeighbour_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRIORA_Bilinear_get___")]
  public static extern int GRIORA_Bilinear_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRIORA_Cubic_get___")]
  public static extern int GRIORA_Cubic_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRIORA_CubicSpline_get___")]
  public static extern int GRIORA_CubicSpline_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRIORA_Lanczos_get___")]
  public static extern int GRIORA_Lanczos_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRIORA_Average_get___")]
  public static extern int GRIORA_Average_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRIORA_RMS_get___")]
  public static extern int GRIORA_RMS_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRIORA_Mode_get___")]
  public static extern int GRIORA_Mode_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRIORA_Gauss_get___")]
  public static extern int GRIORA_Gauss_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_Undefined_get___")]
  public static extern int GCI_Undefined_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_GrayIndex_get___")]
  public static extern int GCI_GrayIndex_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_PaletteIndex_get___")]
  public static extern int GCI_PaletteIndex_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_RedBand_get___")]
  public static extern int GCI_RedBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_GreenBand_get___")]
  public static extern int GCI_GreenBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_BlueBand_get___")]
  public static extern int GCI_BlueBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_AlphaBand_get___")]
  public static extern int GCI_AlphaBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_HueBand_get___")]
  public static extern int GCI_HueBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_SaturationBand_get___")]
  public static extern int GCI_SaturationBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_LightnessBand_get___")]
  public static extern int GCI_LightnessBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_CyanBand_get___")]
  public static extern int GCI_CyanBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_MagentaBand_get___")]
  public static extern int GCI_MagentaBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_YellowBand_get___")]
  public static extern int GCI_YellowBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_BlackBand_get___")]
  public static extern int GCI_BlackBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_YCbCr_YBand_get___")]
  public static extern int GCI_YCbCr_YBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_YCbCr_CrBand_get___")]
  public static extern int GCI_YCbCr_CrBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GCI_YCbCr_CbBand_get___")]
  public static extern int GCI_YCbCr_CbBand_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_NearestNeighbour_get___")]
  public static extern int GRA_NearestNeighbour_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_Bilinear_get___")]
  public static extern int GRA_Bilinear_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_Cubic_get___")]
  public static extern int GRA_Cubic_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_CubicSpline_get___")]
  public static extern int GRA_CubicSpline_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_Lanczos_get___")]
  public static extern int GRA_Lanczos_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_Average_get___")]
  public static extern int GRA_Average_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_RMS_get___")]
  public static extern int GRA_RMS_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_Mode_get___")]
  public static extern int GRA_Mode_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_Max_get___")]
  public static extern int GRA_Max_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_Min_get___")]
  public static extern int GRA_Min_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_Med_get___")]
  public static extern int GRA_Med_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_Q1_get___")]
  public static extern int GRA_Q1_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_Q3_get___")]
  public static extern int GRA_Q3_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRA_Sum_get___")]
  public static extern int GRA_Sum_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GPI_Gray_get___")]
  public static extern int GPI_Gray_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GPI_RGB_get___")]
  public static extern int GPI_RGB_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GPI_CMYK_get___")]
  public static extern int GPI_CMYK_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GPI_HLS_get___")]
  public static extern int GPI_HLS_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CXT_Element_get___")]
  public static extern int CXT_Element_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CXT_Text_get___")]
  public static extern int CXT_Text_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CXT_Attribute_get___")]
  public static extern int CXT_Attribute_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CXT_Comment_get___")]
  public static extern int CXT_Comment_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CXT_Literal_get___")]
  public static extern int CXT_Literal_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CE_None_get___")]
  public static extern int CE_None_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CE_Debug_get___")]
  public static extern int CE_Debug_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CE_Warning_get___")]
  public static extern int CE_Warning_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CE_Failure_get___")]
  public static extern int CE_Failure_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CE_Fatal_get___")]
  public static extern int CE_Fatal_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_None_get___")]
  public static extern int CPLE_None_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_AppDefined_get___")]
  public static extern int CPLE_AppDefined_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_OutOfMemory_get___")]
  public static extern int CPLE_OutOfMemory_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_FileIO_get___")]
  public static extern int CPLE_FileIO_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_OpenFailed_get___")]
  public static extern int CPLE_OpenFailed_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_IllegalArg_get___")]
  public static extern int CPLE_IllegalArg_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_NotSupported_get___")]
  public static extern int CPLE_NotSupported_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_AssertionFailed_get___")]
  public static extern int CPLE_AssertionFailed_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_NoWriteAccess_get___")]
  public static extern int CPLE_NoWriteAccess_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_UserInterrupt_get___")]
  public static extern int CPLE_UserInterrupt_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_ObjectNull_get___")]
  public static extern int CPLE_ObjectNull_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_HttpResponse_get___")]
  public static extern int CPLE_HttpResponse_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_AWSBucketNotFound_get___")]
  public static extern int CPLE_AWSBucketNotFound_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_AWSObjectNotFound_get___")]
  public static extern int CPLE_AWSObjectNotFound_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_AWSAccessDenied_get___")]
  public static extern int CPLE_AWSAccessDenied_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_AWSInvalidCredentials_get___")]
  public static extern int CPLE_AWSInvalidCredentials_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLE_AWSSignatureDoesNotMatch_get___")]
  public static extern int CPLE_AWSSignatureDoesNotMatch_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_OF_ALL_get___")]
  public static extern int OF_ALL_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_OF_RASTER_get___")]
  public static extern int OF_RASTER_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_OF_VECTOR_get___")]
  public static extern int OF_VECTOR_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_OF_GNM_get___")]
  public static extern int OF_GNM_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_OF_MULTIDIM_RASTER_get___")]
  public static extern int OF_MULTIDIM_RASTER_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_OF_READONLY_get___")]
  public static extern int OF_READONLY_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_OF_UPDATE_get___")]
  public static extern int OF_UPDATE_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_OF_SHARED_get___")]
  public static extern int OF_SHARED_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_OF_VERBOSE_ERROR_get___")]
  public static extern int OF_VERBOSE_ERROR_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DMD_LONGNAME_get___")]
  public static extern string GDAL_DMD_LONGNAME_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DMD_HELPTOPIC_get___")]
  public static extern string GDAL_DMD_HELPTOPIC_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DMD_MIMETYPE_get___")]
  public static extern string GDAL_DMD_MIMETYPE_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DMD_EXTENSION_get___")]
  public static extern string GDAL_DMD_EXTENSION_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DMD_EXTENSIONS_get___")]
  public static extern string GDAL_DMD_EXTENSIONS_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DMD_CONNECTION_PREFIX_get___")]
  public static extern string DMD_CONNECTION_PREFIX_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DMD_CREATIONOPTIONLIST_get___")]
  public static extern string GDAL_DMD_CREATIONOPTIONLIST_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DMD_CREATIONDATATYPES_get___")]
  public static extern string GDAL_DMD_CREATIONDATATYPES_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DMD_CREATIONFIELDDATATYPES_get___")]
  public static extern string GDAL_DMD_CREATIONFIELDDATATYPES_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DMD_SUBDATASETS_get___")]
  public static extern string GDAL_DMD_SUBDATASETS_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DMD_CREATION_FIELD_DOMAIN_TYPES_get___")]
  public static extern string GDAL_DMD_CREATION_FIELD_DOMAIN_TYPES_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DCAP_OPEN_get___")]
  public static extern string GDAL_DCAP_OPEN_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DCAP_CREATE_get___")]
  public static extern string GDAL_DCAP_CREATE_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DCAP_CREATECOPY_get___")]
  public static extern string GDAL_DCAP_CREATECOPY_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DCAP_VIRTUALIO_get___")]
  public static extern string GDAL_DCAP_VIRTUALIO_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DCAP_RASTER_get___")]
  public static extern string DCAP_RASTER_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DCAP_VECTOR_get___")]
  public static extern string DCAP_VECTOR_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DCAP_NOTNULL_FIELDS_get___")]
  public static extern string DCAP_NOTNULL_FIELDS_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DCAP_DEFAULT_FIELDS_get___")]
  public static extern string DCAP_DEFAULT_FIELDS_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DCAP_NOTNULL_GEOMFIELDS_get___")]
  public static extern string DCAP_NOTNULL_GEOMFIELDS_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DCAP_UNIQUE_FIELDS_get___")]
  public static extern string DCAP_UNIQUE_FIELDS_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DCAP_COORDINATE_EPOCH_get___")]
  public static extern string DCAP_COORDINATE_EPOCH_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DCAP_FIELD_DOMAINS_get___")]
  public static extern string DCAP_FIELD_DOMAINS_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DCAP_RENAME_LAYERS_get___")]
  public static extern string DCAP_RENAME_LAYERS_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DIM_TYPE_HORIZONTAL_X_get___")]
  public static extern string DIM_TYPE_HORIZONTAL_X_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DIM_TYPE_HORIZONTAL_Y_get___")]
  public static extern string DIM_TYPE_HORIZONTAL_Y_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DIM_TYPE_VERTICAL_get___")]
  public static extern string DIM_TYPE_VERTICAL_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DIM_TYPE_TEMPORAL_get___")]
  public static extern string DIM_TYPE_TEMPORAL_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_DIM_TYPE_PARAMETRIC_get___")]
  public static extern string DIM_TYPE_PARAMETRIC_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLES_BackslashQuotable_get___")]
  public static extern int CPLES_BackslashQuotable_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLES_XML_get___")]
  public static extern int CPLES_XML_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLES_XML_BUT_QUOTES_get___")]
  public static extern int CPLES_XML_BUT_QUOTES_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLES_URL_get___")]
  public static extern int CPLES_URL_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLES_SQL_get___")]
  public static extern int CPLES_SQL_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLES_SQLI_get___")]
  public static extern int CPLES_SQLI_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_CPLES_CSV_get___")]
  public static extern int CPLES_CSV_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFT_Integer_get___")]
  public static extern int GFT_Integer_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFT_Real_get___")]
  public static extern int GFT_Real_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFT_String_get___")]
  public static extern int GFT_String_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_Generic_get___")]
  public static extern int GFU_Generic_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_PixelCount_get___")]
  public static extern int GFU_PixelCount_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_Name_get___")]
  public static extern int GFU_Name_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_Min_get___")]
  public static extern int GFU_Min_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_Max_get___")]
  public static extern int GFU_Max_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_MinMax_get___")]
  public static extern int GFU_MinMax_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_Red_get___")]
  public static extern int GFU_Red_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_Green_get___")]
  public static extern int GFU_Green_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_Blue_get___")]
  public static extern int GFU_Blue_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_Alpha_get___")]
  public static extern int GFU_Alpha_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_RedMin_get___")]
  public static extern int GFU_RedMin_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_GreenMin_get___")]
  public static extern int GFU_GreenMin_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_BlueMin_get___")]
  public static extern int GFU_BlueMin_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_AlphaMin_get___")]
  public static extern int GFU_AlphaMin_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_RedMax_get___")]
  public static extern int GFU_RedMax_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_GreenMax_get___")]
  public static extern int GFU_GreenMax_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_BlueMax_get___")]
  public static extern int GFU_BlueMax_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_AlphaMax_get___")]
  public static extern int GFU_AlphaMax_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GFU_MaxCount_get___")]
  public static extern int GFU_MaxCount_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRTT_THEMATIC_get___")]
  public static extern int GRTT_THEMATIC_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GRTT_ATHEMATIC_get___")]
  public static extern int GRTT_ATHEMATIC_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GMF_ALL_VALID_get___")]
  public static extern int GMF_ALL_VALID_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GMF_PER_DATASET_get___")]
  public static extern int GMF_PER_DATASET_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GMF_ALPHA_get___")]
  public static extern int GMF_ALPHA_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GMF_NODATA_get___")]
  public static extern int GMF_NODATA_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DATA_COVERAGE_STATUS_UNIMPLEMENTED_get___")]
  public static extern int GDAL_DATA_COVERAGE_STATUS_UNIMPLEMENTED_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DATA_COVERAGE_STATUS_DATA_get___")]
  public static extern int GDAL_DATA_COVERAGE_STATUS_DATA_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GDAL_DATA_COVERAGE_STATUS_EMPTY_get___")]
  public static extern int GDAL_DATA_COVERAGE_STATUS_EMPTY_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GARIO_PENDING_get___")]
  public static extern int GARIO_PENDING_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GARIO_UPDATE_get___")]
  public static extern int GARIO_UPDATE_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GARIO_ERROR_get___")]
  public static extern int GARIO_ERROR_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GARIO_COMPLETE_get___")]
  public static extern int GARIO_COMPLETE_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GTO_TIP_get___")]
  public static extern int GTO_TIP_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GTO_BIT_get___")]
  public static extern int GTO_BIT_get();

  [global::System.Runtime.InteropServices.DllImport("gdalconst_wrap", EntryPoint="CSharp_OSGeofGDAL_GTO_BSQ_get___")]
  public static extern int GTO_BSQ_get();
}

}
