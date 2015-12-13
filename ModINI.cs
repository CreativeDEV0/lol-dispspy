
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
static class modINI
{
	[DllImport("kernel32", EntryPoint = "WritePrivateProfileStringW", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
	private static extern Int32 WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
	[DllImport("kernel32", EntryPoint = "GetPrivateProfileStringW", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]

	private static extern Int32 GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, string lpReturnedString, Int32 nSize, string lpFileName);

	public static void writeIni(string iniFileName, string Section, string ParamName, string ParamVal)
	{
		int Result = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName);
	}

	public static string ReadIni(string IniFileName, string Section, string ParamName, string ParamDefault)
	{
		string ParamVal = Strings.Space(1024);
		long LenParamVal = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Strings.Len(ParamVal), IniFileName);
		return Strings.Left(ParamVal, LenParamVal);
	}
}
