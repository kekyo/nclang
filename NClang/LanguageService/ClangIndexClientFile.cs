using System;
using System.Runtime.InteropServices;
using NClang.Natives;

namespace NClang
{

	public class ClangIndexClientFile : ClangObject
	{
		internal ClangIndexClientFile (IntPtr handle)
			: base (handle)
		{
			// no need to dispose handle, clang_disposeIndex() should do that.
		}
	}
}