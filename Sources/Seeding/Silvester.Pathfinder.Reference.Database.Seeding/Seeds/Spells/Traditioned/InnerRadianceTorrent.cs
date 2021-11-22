using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InnerRadianceTorrent : Template
    {
        public static readonly Guid ID = Guid.Parse("520b4336-d8b5-44e8-8b10-15ee285329d3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Inner Radiance Torrent",
                Level = 2,
                Area = "Line 60 feet or longer.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a1039bee-2209-493e-873e-912d3035a28f"), Type = TextBlockType.Text, Text = "You gradually manifest your spiritual energy into your cupped hands before firing off a storm of bolts and beams that deal 4d4 force damage to all creatures in a 60-foot line. Creatures in the area must attempt a basic Reflex save. On a critical failure, they�re also blinded for 1 round. The number of actions you spend when Casting this Spell determines the area. If the line passes through an area of magical darkness or targets a creature affected by magical darkness, inner radiance torrent attempts to counteract the darkness." };
            yield return new TextBlock { Id = Guid.Parse("b5bc6f31-8061-460f-86d3-ad343548b27f"), Type = TextBlockType.Enumeration, Text = "[two-actions] (somatic, verbal) The line is 60 feet long." };
            yield return new TextBlock { Id = Guid.Parse("1e7d24b4-b02d-4662-8c7c-949d2056d080"), Type = TextBlockType.Enumeration, Text = "[three-actions] (material, somatic, verbal) The line is 120 feet long." };
            yield return new TextBlock { Id = Guid.Parse("2b219487-0296-4c7f-93f7-6b519d6d16db"), Type = TextBlockType.Enumeration, Text = "Two Rounds The line is 120 feet long. If you spend 3 actions casting the spell, you can avoid finishing the spell and spend another 3 actions on your next turn to empower the spell even further. If you choose to do so, the damage dealt by this spell increases by 4d4, and you enter a shining state for 1 minute, causing you to glow with light and deal 1 force damage to creatures that end their turn adjacent to you." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9594cdd3-61bb-4e6b-95ff-be8b9301c9f1"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("8a7eba0f-f5a8-40b4-b597-1230cf2c5803"), Type = TextBlockType.Text, Text = "The initial damage, as well as the additional damage for the 2-round casting time, each increase by 4d4, and the damage to adjacent creatures dealt while in your shining state increases by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Force.ID;
            yield return Traits.Instances.Light.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e98de0d-2dd1-4015-bafb-025f67d2008a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 112
            };
        }
    }
}
