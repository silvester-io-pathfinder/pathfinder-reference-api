using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class AncestralEchoing : Template
    {
        public static readonly Guid ID = Guid.Parse("694dff71-27b6-4641-8067-858ddb50f978");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Ancestral Echoing",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("8faff1df-7d66-4cbc-9528-2cf973fedf10"),
                Name = "Ancestral Echoing",
                Usage = "Etched onto a weapon.",
                Level = 15,
                Price = 950000,
                RarityId = Rarities.Instances.Rare.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("e337a626-4b09-4e8c-9bb1-28cc5f89335b"), "The wisdom of this weapon's past owners flows into your mind, amplifying your own abilities with the weapon. Your proficiency rank with this weapon is one step higher than normal, to a maximum of the highest proficiency rank you have in any weapon. For instance, if you had master proficieny with martial weapons and expert proficiency with advanced weapons, you would have master proficiency with advanced weapon that had this rune.")
                    .Text(Guid.Parse("bc8e78cc-7535-4e8e-9e8a-59da36aa6076"), "In addition, while wielding the ancestral echoing weapon, you have expert proficiency in one Lore skill relevant to one or more of the weapon's previous owners. This is typically Dwarven Lore but is ultimately determined by the GM depending on the weapon's history.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("bc09e8b1-ecbb-421c-b9c3-8dce5d852247"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("7d169dbf-ae20-4084-a849-5a7eb74af9c9"), Traits.Instances.Dwarf.ID);
            builder.Add(Guid.Parse("264bded9-024c-46fd-9cbe-05f4f6855864"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("0e7ed850-0ae1-4210-af14-dedfb23d4ce3"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("71cb70d5-172d-426e-88a3-fd75e837399c"), Traits.Instances.Saggorak.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb181177-dc37-4a68-b72a-8210b8fb34ef"),
                SourceId = Sources.Instances.Pathfinder148.ID,
                Page = 75
            };
        }
    }
}
