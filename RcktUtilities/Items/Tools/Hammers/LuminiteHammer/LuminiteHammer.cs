using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RcktUtilities.Items.Tools.Hammers.LuminiteHammer
{
    public class LuminiteHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Luminite Hammer");
            Tooltip.SetDefault("Hammer go brr");
        }

        public override void SetDefaults()
        {
            item.damage = 64; // Base Damage of the Weapon
            item.width = 88; // Hitbox Width
            item.height = 84; // Hitbox Height
            item.useTime = 5; // Speed before reuse
            item.useAnimation = 5; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.knockBack = 1f; // Weapon Knockbase: Higher means greater "launch" distance
            item.value = 5500; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 12; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false

            item.hammer = 100; // Hammer Power - Higher Value = Better
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(1262, 1);
            recipe.AddIngredient(3467, 12);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
