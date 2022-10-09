using HarmonyLib;
using Nick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace SMU.Patches
{
    [HarmonyPatch(typeof(Localization), nameof(Localization.GetText), new Type[] { typeof(string) })]
    class Localization_GetText
    {
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var instruction = instructions.Last(x => x.opcode == OpCodes.Ldsfld);

            instruction.opcode = OpCodes.Ldarg_0;
            instruction.operand = null;

            return instructions;
        }
    }
}
