using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientTerraBlade.Content
{
	public class AncientMuramasa : ModItem
	{
		public override void SetDefaults() {
			Item.damage = 26;
			Item.crit = 4;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 18;
			Item.useAnimation = 18;
			Item.scale = 1f;
			Item.useStyle = 1;
			Item.autoReuse = true;
			Item.knockBack = 3f;
			Item.UseSound = SoundID.Item1;
			Item.rare = ItemRarityID.Green;
			Item.value = Item.buyPrice(0, 8, 75, 0);
		}
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Bone, 30)
				.AddIngredient(ItemID.DemoniteBar, 10)
				.AddTile(TileID.Anvils)
				.Register();	
			CreateRecipe()
				.AddIngredient(ItemID.Bone, 30)
				.AddIngredient(ItemID.CrimtaneBar, 10)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}