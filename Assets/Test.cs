using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text libDirText;
	public Text abiText;
	public Text abi2Text;
	public Text archText;
	public Text cpuFamilyText;
	public Text cpuFeaturesText;

	void Start ()
    {
		Debug.Log("Test Start");

		using (AndroidJavaClass sysProp = new AndroidJavaClass("android.os.SystemProperties"),
			                        sys = new AndroidJavaClass("java.lang.System"))
        {
			abiText.text = "ro.product.cpu.abi = " + sysProp.CallStatic<string>("get", "ro.product.cpu.abi");
			abi2Text.text = "ro.product.cpu.abi2 = " + sysProp.CallStatic<string>("get", "ro.product.cpu.abi2");
			archText.text = "os.arch = " + sys.CallStatic<string>("getProperty", "os.arch");
        }

		libDirText.text = "lib dir = " + CPUArch.get_lib_dir();
		cpuFamilyText.text = "CPU Family = " + CPUArch.get_cpu_family();
		cpuFeaturesText.text = "CPU Features = " + CPUArch.get_cpu_features();

		Debug.Log("Test End");
	}
}
