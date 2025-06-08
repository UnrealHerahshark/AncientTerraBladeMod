using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientTerraBlade.Content
{
	public class TrueAncientExcalibur : ModItem
	{
		public override void SetDefaults() {
			Item.damage = 70;
			Item.crit = 4;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 16;
			Item.useAnimation = 16;
			Item.scale = 1f;
			Item.useStyle = 1;
			Item.autoReuse = true;
			Item.knockBack = 4.5f;
			Item.UseSound = SoundID.Item1;
			Item.shoot = 156;
			Item.shootSpeed = 12f;
			Item.rare = ItemRarityID.Yellow;
			Item.value = Item.buyPrice(0, 23, 0, 0);
		}
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<AncientExcalibur>()
				.AddIngredient(ItemID.ChlorophyteBar, 24)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}