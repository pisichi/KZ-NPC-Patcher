using Mutagen.Bethesda;
using Mutagen.Bethesda.Skyrim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noggog;
using Mutagen.Bethesda.Synthesis.Settings;

namespace KZNPCPatchers
{
    public record Settings
    {
        [SynthesisOrder]
        [SynthesisTooltip("Directory to which facegen should be copied (Your mod folder)")]
        public string FacegenOutputDirectory { get; set; } = "";

        [SynthesisOrder]
        [SynthesisTooltip("target mod")]
        public List<ModKey> TargetMods = new List<ModKey>();


        [SynthesisOrder]
        [SynthesisTooltip("Use same name = same appearance")]
        public bool SameName  = false;

        // [SynthesisOrder]
        // [SynthesisTooltip("Use same Weight")]
        // public bool SameWeight  = false;
    }
}
