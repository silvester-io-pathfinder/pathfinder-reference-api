using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Updraft : Template
    {
        public static readonly Guid ID = Guid.Parse("fb9682b5-6076-45cd-9b01-237b1254a972");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Updraft",
                Level = 1,
                Range = "60 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b4476ad-41fb-4d04-8ed4-9cbed7b1e21b"), Type = TextBlockType.Text, Text = "A powerful blast of wind erupts from the ground, launching the target into the air and sending it crashing back down. The collision deals 2d6 bludgeoning damage with a basic Reflex save. On a failure, the target is knocked prone." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("39c5aeb9-9bad-45b2-9edc-a399a8e46cd5"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("ab8f9bc9-ac74-4ff7-bfbe-c5f8329651a8"), Type = TextBlockType.Text, Text = "Increase the damage by 2d6." }
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
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7a43478-23fd-4a0e-ac05-0e52979965f6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 201
            };
        }
    }
}