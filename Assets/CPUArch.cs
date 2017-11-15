using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class CPUArch : MonoBehaviour
{
	[DllImport("cpuarch")]
	public static extern int get_cpu_arch();
	
	[DllImport("cpuarch")]
	public static extern int get_cpu_family();
	
	[DllImport("cpuarch")]
	public static extern UInt64 get_cpu_features();
	
	public static string get_lib_dir()
	{
		int abi_type = get_cpu_arch();
		if (abi_type == 0)
		{
			return "armeabi";
		}
		else if (abi_type == 1)
		{
			return "armeabi-v7a";
		}
		else if (abi_type == 2)
		{
			return "x86";
		}
		return "armeabi";
	}
}