using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class StormwindFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("d3a60ed6-b434-4f80-a3a0-9579481617a7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Stormwind Flight",
                Level = 4,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("660aed99-247f-4f87-a8f2-25c25d69e984"), Type = TextBlockType.Text, Text = "Powerful winds carry you smoothly through the air, giving you a fly Speed equal to your Speed. When this spell's duration would end, if you're still flying, you float to the ground, as feather fall." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e96c9d70-88ef-4e98-9117-92ed469f7d88"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ef01260a-2504-4d87-a743-a51a1331d5a5"), Type = TextBlockType.Text, Text = "When you fly using stormwind flight, you don't count flying against the wind as difficult terrain." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Druid.ID;
            yield return Traits.Instances.Transmutation.ID;
        }  

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ee145f5-c59f-43cf-ad4f-50a0b150205b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 400
            };
        }
    }
}
