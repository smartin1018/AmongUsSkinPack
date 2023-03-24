using UnityEngine;

namespace PlateUpAmogus
{
    public class AmongUsPlayerModel : CustomPlayerModel
    {
        public override string UniqueNameID => "AmongUsPlayerModel";
        public override GameObject Prefab => (GameObject)Main.Bundle.LoadAsset("assets/mods/assetbundle/amogus_plateup_v2.prefab");
        public override Mesh Mesh => Prefab.GetComponentInChildren<SkinnedMeshRenderer>().sharedMesh;
    }
}