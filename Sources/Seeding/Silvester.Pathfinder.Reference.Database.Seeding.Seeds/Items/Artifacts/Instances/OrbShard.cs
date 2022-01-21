using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Artifacts.Instances
{
    public class OrbShard : Template
    {
        public static readonly Guid ID = Guid.Parse("f0a73799-c5d5-4f5f-b530-aada27ca8baa");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Orb Shard",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1bd8a075-059d-4bcb-bad3-b6d372ddaf5d"), "A shard of the Orb of Gold Dragonkind resembles a pointed length of crystal about the size and shape of a shortsword without a hilt. It functions as a +3 striking shortsword that deals 2d6 extra damage to dragons.");;
            builder.Text(Guid.Parse("92ad78b6-250c-4920-a728-0b89458eff84"), "Each orb shard within 60 feet of the flawed orb of Gold Dragonkind increases the save DC against the orb by 1; thus, if all 13 remaining orb shards are in this area, the save DC against the flawed orb increases from DC 30 to DC 43. A talented spellcaster or crafter can integrate an orb shard back into the flawed orb to make this DC increase permanent.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("e5c768c3-7f0a-4272-90a9-3c8edc3116b2"),
                Name = "Orb Shard",
                Hands = 1,
                Destruction = "An orb shard is extraordinarily resilient, but it can be damaged or even destroyed by mundane attacks (Hardness 40, HP 50, BT 25). It has weakness 30 to the Breath Weapons and Strikes of gold dragons.",
                Level = 20,
                RarityId = Rarities.Instances.Rare.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("669805bf-9b04-4c34-bc3c-c07c4d7657fa"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("083380d7-bcfa-4ba8-9c29-45e3d15b4046"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("2bafc151-46da-488f-9288-2c4078eceee0"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("c3579106-e715-4707-a668-2473a8480de3"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58a8b944-aade-413c-a842-daeae038b491"),
                SourceId = Sources.Instances.Pathfinder150.ID,
                Page = 75
            };
        }
    }
}
