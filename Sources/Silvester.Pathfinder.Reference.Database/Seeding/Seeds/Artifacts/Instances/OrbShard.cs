using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts.Instances
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
                Destruction = "An orb shard is extraordinarily resilient, but it can be damaged or even destroyed by mundane attacks (Hardness 40, HP 50, BT 25). It has weakness 30 to the Breath Weapons and Strikes of gold dragons.",
                Usage = "Held in 1 hand.",
                ItemLevel = 20,
                BulkId = Bulks.Instances.NegligibleBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1bd8a075-059d-4bcb-bad3-b6d372ddaf5d"), Type = TextBlockType.Text, Text = "A shard of the Orb of Gold Dragonkind resembles a pointed length of crystal about the size and shape of a shortsword without a hilt. It functions as a +3 striking shortsword that deals 2d6 extra damage to dragons." };
            yield return new TextBlock { Id = Guid.Parse("92ad78b6-250c-4920-a728-0b89458eff84"), Type = TextBlockType.Text, Text = "Each orb shard within 60 feet of the flawed orb of Gold Dragonkind increases the save DC against the orb by 1; thus, if all 13 remaining orb shards are in this area, the save DC against the flawed orb increases from DC 30 to DC 43. A talented spellcaster or crafter can integrate an orb shard back into the flawed orb to make this DC increase permanent." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Magical.ID;
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
