using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tsorcRevamp.Items.Weapons
{
    public class HeavensTear : ModItem
    {
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("Heaven's Tear");
            Tooltip.SetDefault("'Heaven splits with each swing'\n" +
                                "Does 2x damage to mages and ghosts...");

	}

        public override void SetDefaults()
        {
            
            item.width = 32;
            item.height = 32;
            //item.pretendType=389;
            //item.prefixType=368;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.channel = true;
            item.useAnimation = 38;
            item.useTime = 38;
            item.maxStack = 1;
            item.damage = 350;
            item.knockBack = (float)10;
            item.scale = (float)1.1;
            item.UseSound = SoundID.Item1;
            item.rare = ItemRarityID.Pink;
            item.shootSpeed = (float)14; 
            item.noUseGraphic = true;
            item.noMelee = true;
            item.value = 2500000;
            item.melee = true;
            item.shoot = ModContent.ProjectileType<Projectiles.HeavenBall>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            //recipe.AddIngredient(ModLoader.GetMod("DarkSouls"), "EnchantedMorningStar", 1);
            recipe.AddIngredient(ModLoader.GetMod("DarkSouls"), "GuardianSoul", 1);
            recipe.AddIngredient(ModLoader.GetMod("DarkSouls"), "CursedSoul", 60);
            recipe.AddIngredient(ModLoader.GetMod("DarkSouls"), "FlameOfTheAbyss", 17);
            recipe.AddIngredient(ModLoader.GetMod("DarkSouls"), "DarkSoul", 120000);

            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }

        public override void OnHitNPC( Terraria.Player P, NPC npc, int damage, float KB, bool crit )
        {
            //damage = (int) ((Main.rand.Next(26)) * (P.meleeDamage));
            if (npc.FullName == "Tim") damage *= 2;
            else if (npc.FullName == "Dark Caster") damage *= 2;
            else if (npc.FullName == "Goblin Sorcerer") damage *= 2;
            //else if (npc.FullName == "Undead Caster") damage *= 2;
            //else if (npc.FullName == "Mindflayer Servant") damage *= 2;
            //else if (npc.FullName == "Dungeon Mage") damage *= 2;
            //else if (npc.FullName == "Demon Spirit") damage *= 2;
            //else if (npc.FullName == "Crazed Demon Spirit") damage *= 2;
            //else if (npc.FullName == "Shadow Mage") damage *= 2;
            //else if (npc.FullName == "Attraidies Illusion") damage *= 2;
            //else if (npc.FullName == "Attraidies Manifestation") damage *= 2;
            //else if (npc.FullName == "Mindflayer King") damage *= 2;
            //else if (npc.FullName == "Dark Shogun Mask") damage *= 2;
            //else if (npc.FullName == "Dark Dragon Mask") damage *= 2;
            //else if (npc.FullName == "Broken Okiku") damage *= 2;
            //else if (npc.FullName == "Okiku") damage *= 2;
            //else if (npc.FullName == "Wyvern Mage") damage *= 2;
            //else if (npc.FullName == "Ghost of the Forgotten Knight") damage *= 2;
            //else if (npc.FullName == "Ghost of the Forgotten Warrior") damage *= 2;
            //else if (npc.FullName == "Barrow Wight Nemesis") damage *= 2;
            //else if (npc.FullName == "Oolacile Sorcerer") damage *= 2;
            //else if (npc.FullName == "Abysmal Oolacile Sorcerer") damage *= 2;
            //else if (npc.FullName == "Dark Cloud") damage *= 2;
            //else if (npc.FullName == "Barrow Wight") damage *= 2;
        }

    }
}
