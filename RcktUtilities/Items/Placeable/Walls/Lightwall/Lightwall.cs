using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RcktUtilities.Items.Placeable.Walls.Lightwall
{
    public class Lightwall : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightwall");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.value = 50;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createWall = mod.WallType("Lightwall");
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WhiteTorch, 1);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
        }
    }
}