using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EidolonsWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("f585a1b3-830d-43c2-af96-07df465b5c94");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Eidolon's Wrath",
                Level = 3,
                Area = "20-foot radius emanation around your eidolon.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
                ClassId = Classes.Instances.Summoner.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0255404e-9d3e-44c9-9022-c86665e40660"), Type = TextBlockType.Text, Text = "Your eidolon releases a powerful energy attack that deals 5d6 damage of the type you chose when you took the Eidolon�s Wrath feat, with a basic Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3f8837e6-24e0-4923-8611-2cd5112f6ddd"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3cef545a-929b-4c51-b2c7-73b0cf1e1bd9"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return Traits.Instances.Eidolon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Summoner.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba48b867-936d-4b5e-8580-00a1f1b0cea1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 144
            };
        }
    }
}
