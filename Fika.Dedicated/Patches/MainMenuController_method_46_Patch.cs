﻿using SPT.Reflection.Patching;
using System.Reflection;

namespace Fika.Dedicated.Patches
{
    public class MainMenuController_method_46_Patch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return typeof(MainMenuController).GetMethod(nameof(MainMenuController.method_46));
        }

        [PatchPrefix]
        private static bool Prefix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}
