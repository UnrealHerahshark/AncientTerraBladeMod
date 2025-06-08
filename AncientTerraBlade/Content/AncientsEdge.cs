using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientTerraBlade.Content
{
	public class AncientsEdge : ModItem
	{
		public override void SetDefaults() {
			Item.damage = 42;
			Item.crit = 4;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 21;
			Item.useAnimation = 21;
			Item.scale = 1f;
			Item.useStyle = 1;
			Item.autoReuse = true;
			Item.knockBack = 4.5f;
			Item.UseSound = SoundID.Item1;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.buyPrice(0, 20, 0, 0);
		}
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<AncientMuramasa>()
				.AddIngredient<AncientsBane>()
				.AddIngredient<FieryGreatsword>()
				.AddIngredient<AncientBladeofGrass>()
				.AddTile(TileID.DemonAltar)
				.Register();
			CreateRecipe()
				.AddIngredient<AncientMuramasa>()
				.AddIngredient<AncientsButcherer>()
				.AddIngredient<FieryGreatsword>()
				.AddIngredient<AncientBladeofGrass>()
				.AddTile(TileID.DemonAltar)
				.Register();
		}
	}
}