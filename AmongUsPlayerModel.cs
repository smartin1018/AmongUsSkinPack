using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenPlayerModelLib;
using UnityEngine;

namespace KitchenAmongUs
{
    public class AmongUsPlayerModel : CustomPlayerModel
    {
        public override string UniqueNameID => "AmongUsPlayerModel";
        public override GameObject Prefab => (GameObject)Mod.Bundle.LoadAsset("assets/mod/amogus_plateup_v2.prefab");

        public override Mesh Mesh => Prefab.GetComponentInChildren<SkinnedMeshRenderer>().sharedMesh;
        
        private Material AmongUsVisor => CustomMaterials.GetCustomMaterial("AmongUsVisor");
        
        private Material AmongUsVisorSeal => CustomMaterials.GetCustomMaterial("AmongUsVisorSeal");

        public override Material[] Materials => new[]
        {
            null, AmongUsVisorSeal, AmongUsVisor
        };
    }
}