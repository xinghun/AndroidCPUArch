#include <cpu-features.h>

int get_cpu_arch()
{
    AndroidCpuFamily family = android_getCpuFamily();
    if (family == ANDROID_CPU_FAMILY_ARM)
    {
        uint64_t features = android_getCpuFeatures();
        if (features & ANDROID_CPU_ARM_FEATURE_ARMv7)
        {
            return 1;   // armeabi-v7a
        }
        return 0;       // armeabi
    }
    if (family == ANDROID_CPU_FAMILY_X86)
    {
        return 2;       // x86
    }
    return 0;           // default: armeabi
}

int get_cpu_family()
{
    return (int)android_getCpuFamily();
}

uint64_t get_cpu_features()
{
    return android_getCpuFeatures();
}
