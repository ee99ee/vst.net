﻿namespace Jacobi.Vst.Core
{
    public interface IVstHostCommandStubBase
    {
        bool IsInitialized();
        bool UpdatePluginInfo(VstPluginInfo pluginInfo);
    }

    public interface IVstHostCommandStub10 : IVstHostCommandStubBase
    {
        void SetParameterAutomated(int index, float value);
        int GetVersion();
        int GetCurrentPluginID();
        void ProcessIdle();
    }

    public interface IVstHostCommandStub20 : IVstHostCommandStub10
    {
        VstTimeInfo GetTimeInfo(VstTimeInfoFlags filterFlags);
        bool ProcessEvents(VstEvent[] events);
        bool IoChanged();
        bool SizeWindow(int width, int height);
        double GetSampleRate();
        int GetBlockSize();
        int GetInputLatency();
        int GetOutputLatency();
        VstProcessLevels GetProcessLevel();
        VstAutomationStates GetAutomationState();
        bool OfflineRead(VstOfflineTask task, VstOfflineOption option, bool readSource);
        bool OfflineWrite(VstOfflineTask task, VstOfflineOption option);
        bool OfflineStart(VstAudioFile[] files, int numberOfAudioFiles, int numberOfNewAudioFiles);
        int OfflineGetCurrentPass();
        int OfflineGetCurrentMetaPass();
        string GetVendorString();
        string GetProductString();
        int GetVendorVersion();
        VstCanDoResult CanDo(VstHostCanDo cando);
        VstHostLanguage GetLanguage();
        string GetDirectory();
        bool UpdateDisplay();
        bool BeginEdit(int index);
        bool EndEdit(int index);
        bool OpenFileSelector(/*VstFileSelect*/);
        bool CloseFileSelector(/*VstFileSelect*/);
    }

    // alias for latest version
    public interface IVstHostCommandStub : IVstHostCommandStub20
    { }
}