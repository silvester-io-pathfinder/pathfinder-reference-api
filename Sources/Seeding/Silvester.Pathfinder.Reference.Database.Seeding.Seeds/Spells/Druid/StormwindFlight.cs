using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("631cef67-fb12-482b-b5ac-de46ee25753d"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("83afcf73-04b0-4e82-bacf-38cde6b5d9f9"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("f70f24db-8cac-4e69-89a1-f9da971a96e2"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("7444f217-2299-4c28-91ae-8ce4460f9f98"), Traits.Instances.Transmutation.ID);
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
