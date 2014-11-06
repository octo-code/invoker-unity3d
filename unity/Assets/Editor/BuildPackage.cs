
using System.IO;

using UnityEngine;
using UnityEditor;

public class BuildPackage 
{
	public static string[] m_PackageInputPaths = 
	{
		"Assets/Invocation"
	};
	public const string m_PackageOutputPath = "../build/invoker.unitypackage";

	[MenuItem("Build/Invoker/Build Package")]
	public static void BuildUnityPackage()
	{
		AssetDatabase.ExportPackage(m_PackageInputPaths, m_PackageOutputPath, ExportPackageOptions.Recurse);
	}
}
