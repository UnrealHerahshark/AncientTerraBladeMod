using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientTerraBlade.Content
{
	public class AncientExcalibur : ModItem
	{
		public override void SetDefaults() {
			Item.damage = 66;
			Item.crit = 4;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.scale = 1f;
			Item.useStyle = 1;
			Item.autoReuse = true;
			Item.knockBack = 4.5f;
			Item.UseSound = SoundID.Item1;
			Item.rare = ItemRarityID.Pink;
			Item.value = Item.buyPrice(0, 23, 0, 0);
		}
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.HallowedBar, 12)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}