// THIS FILE AUTOMATICALLY GENERATED BY xpidl2cs.pl
// EDITING IS PROBABLY UNWISE
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2007, 2008 Novell, Inc.
//
// Authors:
//	Andreia Gaita (avidigal@novell.com)
//

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mono.Mozilla {

	[Guid ("b7ae45bd-21e9-4ed5-a67e-86448b25d56b")]
	[InterfaceType (ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport ()]
	internal interface nsIAccessibleDocument {

#region nsIAccessibleDocument
		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getURL ( /*AString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getTitle ( /*AString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getMimeType ( /*AString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getDocType ( /*AString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getDocument ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMDocument ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getWindow ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMWindow ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getNameSpaceURIForID ( short nameSpaceID,
				 /*AString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getWindowHandle ( IntPtr ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getCachedAccessNode ( IntPtr aUniqueID,
				[MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getAccessibleInParentChain ([MarshalAs (UnmanagedType.Interface) ]  nsIDOMNode aDOMNode,
				 bool aCanCreate,
				[MarshalAs (UnmanagedType.Interface) ] out nsIAccessible ret);

#endregion
	}


	internal class nsAccessibleDocument {
		public static nsIAccessibleDocument GetProxy (Mono.WebBrowser.IWebBrowser control, nsIAccessibleDocument obj)
		{
			object o = Base.GetProxyForObject (control, typeof(nsIAccessibleDocument).GUID, obj);
			return o as nsIAccessibleDocument;
		}
	}
}
#if example

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

	internal class AccessibleDocument : nsIAccessibleDocument {

#region nsIAccessibleDocument
		int nsIAccessibleDocument.getURL ( /*AString*/ HandleRef ret)

		{
			return null;
		}

		int nsIAccessibleDocument.getTitle ( /*AString*/ HandleRef ret)

		{
			return null;
		}

		int nsIAccessibleDocument.getMimeType ( /*AString*/ HandleRef ret)

		{
			return null;
		}

		int nsIAccessibleDocument.getDocType ( /*AString*/ HandleRef ret)

		{
			return null;
		}

		int nsIAccessibleDocument.getDocument ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMDocument ret)

		{
			return null;
		}

		int nsIAccessibleDocument.getWindow ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMWindow ret)

		{
			return null;
		}

		int nsIAccessibleDocument.getNameSpaceURIForID ( short nameSpaceID,
				 /*AString*/ HandleRef ret)
		{
			return ;
		}



		int nsIAccessibleDocument.getWindowHandle ( IntPtr ret)

		{
			return IntPtr.Zero;
		}

		int nsIAccessibleDocument.getCachedAccessNode ( IntPtr aUniqueID,
				[MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret)
		{
			return ;
		}



		int nsIAccessibleDocument.getAccessibleInParentChain ([MarshalAs (UnmanagedType.Interface) ]  nsIDOMNode aDOMNode,
				 bool aCanCreate,
				[MarshalAs (UnmanagedType.Interface) ] out nsIAccessible ret)
		{
			return ;
		}



#endregion
	}
#endif
