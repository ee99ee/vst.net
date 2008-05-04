﻿namespace Jacobi.Vst.Core
{
    using System;

    public class VstMidiProgramName
    {
        public int CurrentProgramIndex;

        public VstMidiProgramNameFlags Flags;
        public string Name;
        public byte MidiProgram;
        public byte MidiBankLSB;
        public byte MidiBankMSB;
        public int ParentCategoryIndex;
    }

    [Flags]
    public enum VstMidiProgramNameFlags
    {
        None = 0,
        MidiIsOmni = 1,
    }
}