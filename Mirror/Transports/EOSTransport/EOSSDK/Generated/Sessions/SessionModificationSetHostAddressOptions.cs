// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionModification.SetHostAddress" /> function.
	/// </summary>
	public struct SessionModificationSetHostAddressOptions
	{
		/// <summary>
		/// A string representing the host address for the session, its meaning is up to the application
		/// </summary>
		public Utf8String HostAddress { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionModificationSetHostAddressOptionsInternal : ISettable<SessionModificationSetHostAddressOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_HostAddress;

		public Utf8String HostAddress
		{
			set
			{
				Helper.Set(value, ref m_HostAddress);
			}
		}

		public void Set(ref SessionModificationSetHostAddressOptions other)
		{
			m_ApiVersion = SessionModification.SessionmodificationSethostaddressApiLatest;
			HostAddress = other.HostAddress;
		}

		public void Set(ref SessionModificationSetHostAddressOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = SessionModification.SessionmodificationSethostaddressApiLatest;
				HostAddress = other.Value.HostAddress;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_HostAddress);
		}
	}
}