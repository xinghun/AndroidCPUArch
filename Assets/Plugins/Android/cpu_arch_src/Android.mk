LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS) 

LOCAL_MODULE := libcpuarch_static
LOCAL_MODULE_FILENAME := libcpuarch
cmd-strip = $(TOOLCHAIN_PREFIX)strip --strip-unneeded -x $1
LOCAL_SRC_FILES := cpu_arch.c
LOCAL_LDLIBS := -llog
LOCAL_STATIC_LIBRARIES := cpufeatures
include $(BUILD_SHARED_LIBRARY)

$(call import-module,android/cpufeatures)
