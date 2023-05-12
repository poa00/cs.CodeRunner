using System.Runtime.InteropServices;

namespace CodeRunner.Worker.Extensions;

public static class StringExtensions
{
    public static byte[] ToByteArray(this string s) => s.ToByteSpan().ToArray(); //  heap allocation, use only when you cannot operate on spans
    public static ReadOnlySpan<byte> ToByteSpan(this string s) => MemoryMarshal.AsBytes(s.AsSpan());
}