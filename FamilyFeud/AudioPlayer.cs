using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace FamilyFeud {

	/// <summary>
	/// Summary description for AudioPlayer.
	/// </summary>
	public class AudioPlayer {
		[DllImport("winmm.dll")]
		public static extern bool PlaySound(byte[] data, IntPtr hMod, UInt32 dwFlags);
		public const UInt32 SND_ASYNC = 1;
		public const UInt32 SND_MEMORY = 4;

		public AudioPlayer() {
			
		}

		public static void PlaySound(string path) {
			Assembly assm = Assembly.GetExecutingAssembly();
			Stream s = assm.GetManifestResourceStream(path);
			byte[] bStream = new byte[s.Length];
			s.Read(bStream, 0, (int)s.Length);
			PlaySound(bStream, IntPtr.Zero, SND_ASYNC | SND_MEMORY);
		}
	}
}