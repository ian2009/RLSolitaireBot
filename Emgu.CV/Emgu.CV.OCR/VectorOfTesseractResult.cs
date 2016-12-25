﻿//----------------------------------------------------------------------------
//
//  Copyright (C) 2004-2016 by EMGU Corporation. All rights reserved.
//
//  Vector of TesseractResult
//
//  This file is automatically generated, do not modify.
//----------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Emgu.CV.Structure;
#if !NETFX_CORE
using System.Runtime.Serialization;
#endif

namespace Emgu.CV.OCR
{
   /// <summary>
   /// Wrapped class of the C++ standard vector of TesseractResult.
   /// </summary>
#if !NETFX_CORE
   [Serializable]
   [DebuggerTypeProxy(typeof(VectorOfTesseractResult.DebuggerProxy))]
#endif
   public partial class VectorOfTesseractResult : Emgu.Util.UnmanagedObject, IInputOutputArray
#if !NETFX_CORE
   , ISerializable
#endif
   {
      private readonly bool _needDispose;
   
      static VectorOfTesseractResult()
      {
         CvInvoke.CheckLibraryLoaded();
         Debug.Assert(Emgu.Util.Toolbox.SizeOf<TesseractResult>() == SizeOfItemInBytes, "Size do not match");
      }

#if !NETFX_CORE
      /// <summary>
      /// Constructor used to deserialize runtime serialized object
      /// </summary>
      /// <param name="info">The serialization info</param>
      /// <param name="context">The streaming context</param>
      public VectorOfTesseractResult(SerializationInfo info, StreamingContext context)
         : this()
      {
         Push((TesseractResult[])info.GetValue("TesseractResultArray", typeof(TesseractResult[])));
      }
	  
	   /// <summary>
      /// A function used for runtime serialization of the object
      /// </summary>
      /// <param name="info">Serialization info</param>
      /// <param name="context">Streaming context</param>
      public void GetObjectData(SerializationInfo info, StreamingContext context)
      {
         info.AddValue("TesseractResultArray", ToArray());
      }
#endif

      /// <summary>
      /// Create an empty standard vector of TesseractResult
      /// </summary>
      public VectorOfTesseractResult()
         : this(VectorOfTesseractResultCreate(), true)
      {
      }
	  
	   internal VectorOfTesseractResult(IntPtr ptr, bool needDispose)
      {
         _ptr = ptr;
         _needDispose = needDispose;
      }

      /// <summary>
      /// Create an standard vector of TesseractResult of the specific size
      /// </summary>
      /// <param name="size">The size of the vector</param>
      public VectorOfTesseractResult(int size)
         : this( VectorOfTesseractResultCreateSize(size), true)
      {
      }
	  
	   /// <summary>
      /// Create an standard vector of TesseractResult with the initial values
      /// </summary>
      /// <param name="values">The initial values</param>
	   public VectorOfTesseractResult(TesseractResult[] values)
         :this()
      {
         Push(values);
      }
	  
      /// <summary>
      /// Push an array of value into the standard vector
      /// </summary>
      /// <param name="value">The value to be pushed to the vector</param>
      public void Push(TesseractResult[] value)
      {
         if (value.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(value, GCHandleType.Pinned);
            VectorOfTesseractResultPushMulti(_ptr, handle.AddrOfPinnedObject(), value.Length);
            handle.Free();
         }
      }
      
      /// <summary>
      /// Push multiple values from the other vector into this vector
      /// </summary>
      /// <param name="other">The other vector, from which the values will be pushed to the current vector</param>
      public void Push(VectorOfTesseractResult other)
      {
         VectorOfTesseractResultPushVector(_ptr, other);
      }
	  
	   /// <summary>
      /// Convert the standard vector to an array of TesseractResult
      /// </summary>
      /// <returns>An array of TesseractResult</returns>
      public TesseractResult[] ToArray()
      {
         TesseractResult[] res = new TesseractResult[Size];
         if (res.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(res, GCHandleType.Pinned);
            VectorOfTesseractResultCopyData(_ptr, handle.AddrOfPinnedObject());
            handle.Free();
         }
         return res;
      }

      /// <summary>
      /// Get the size of the vector
      /// </summary>
      public int Size
      {
         get
         {
            return VectorOfTesseractResultGetSize(_ptr);
         }
      }

      /// <summary>
      /// Clear the vector
      /// </summary>
      public void Clear()
      {
         VectorOfTesseractResultClear(_ptr);
      }

      /// <summary>
      /// The pointer to the first element on the vector. In case of an empty vector, IntPtr.Zero will be returned.
      /// </summary>
      public IntPtr StartAddress
      {
         get
         {
            return VectorOfTesseractResultGetStartAddress(_ptr);
         }
      }
	  
	   /// <summary>
      /// Get the item in the specific index
      /// </summary>
      /// <param name="index">The index</param>
      /// <returns>The item in the specific index</returns>
      public TesseractResult this[int index]
      {
         get
         {
            TesseractResult result = new TesseractResult();
            VectorOfTesseractResultGetItem(_ptr, index, ref result);
            return result;
         }
      }

      /// <summary>
      /// Release the standard vector
      /// </summary>
      protected override void DisposeObject()
      {
         if (_needDispose && _ptr != IntPtr.Zero)
            VectorOfTesseractResultRelease(ref _ptr);
      }

	   /// <summary>
      /// Get the pointer to cv::_InputArray
      /// </summary>
      public InputArray GetInputArray()
      {
         return new InputArray( cvInputArrayFromVectorOfTesseractResult(_ptr), this );
      }
	  
	   /// <summary>
      /// Get the pointer to cv::_OutputArray
      /// </summary>
      public OutputArray GetOutputArray()
      {
         return new OutputArray( cvOutputArrayFromVectorOfTesseractResult(_ptr), this );
      }

	   /// <summary>
      /// Get the pointer to cv::_InputOutputArray
      /// </summary>
      public InputOutputArray GetInputOutputArray()
      {
         return new InputOutputArray( cvInputOutputArrayFromVectorOfTesseractResult(_ptr), this );
      }
      
      /// <summary>
      /// The size of the item in this Vector, counted as size in bytes.
      /// </summary>
      public static int SizeOfItemInBytes
      {
         get { return VectorOfTesseractResultSizeOfItemInBytes(); }
      }
	  
      internal class DebuggerProxy
      {
         private VectorOfTesseractResult _v;

         public DebuggerProxy(VectorOfTesseractResult v)
         {
            _v = v;
         }

         public TesseractResult[] Values
         {
            get { return _v.ToArray(); }
         }
      }

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfTesseractResultCreate();

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfTesseractResultCreateSize(int size);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTesseractResultRelease(ref IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfTesseractResultGetSize(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTesseractResultCopyData(IntPtr v, IntPtr data);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfTesseractResultGetStartAddress(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTesseractResultPushMulti(IntPtr v, IntPtr values, int count);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTesseractResultPushVector(IntPtr ptr, IntPtr otherPtr);
      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTesseractResultClear(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTesseractResultGetItem(IntPtr vec, int index, ref TesseractResult element);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfTesseractResultSizeOfItemInBytes();
      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvInputArrayFromVectorOfTesseractResult(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvOutputArrayFromVectorOfTesseractResult(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvInputOutputArrayFromVectorOfTesseractResult(IntPtr vec);
   }
}
