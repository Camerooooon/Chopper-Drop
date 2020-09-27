using System.Collections.Generic;
using Exiled.API.Interfaces;

namespace ChopperDrop
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public Dictionary<ItemType,int> ChopperItems { get; set; } = new Dictionary<ItemType, int> { {ItemType.GunE11SR, 1}, {ItemType.Medkit, 3}, {ItemType.Adrenaline, 2}, {ItemType.Ammo762, 2}};
        public int ChopperTime { get; set; } = 600;
        public string ChopperText { get; set; } = "<color=lime>A supply drop is at the surface!</color>";
        public string CassieAnnouncement { get; set; } = "pitch_0.96 .g4 supplys have jam_20_2 arrival on the surface of the facility .g3 . .g3 jam_20_5 all remaining mobile task force operatives are advised to proceed to the surface for supplys .g4";
    }
}