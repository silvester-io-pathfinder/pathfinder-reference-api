using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Sorcerer.Instances
{
    public class HellfirePlume : Template
    {
        public static readonly Guid ID = Guid.Parse("ce60a626-8eca-4893-9329-6518d60f1bea");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hellfire Plume",
                Level = 5,
                Range = "60 feet.",
                Area = "10-foot radius, 60-foot-tall cylinder.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1a3db4e2-76e4-4f72-a7ec-052b4d96e1c5"), Type = TextBlockType.Text, Text = "You call forth a plume of hellfire that erupts from below, dealing 4d6 fire damage and 4d6 evil damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2585dd26-a87f-4848-9a1d-e6ca3e5b0ad8"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("14caa690-f241-41a7-a5ff-3bd979292615"), Type = TextBlockType.Text, Text = "The fire damage increases by 1d6, and the evil damage increases by 1d6." }
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
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4282d9c-792d-41b7-bf6f-c65e9bd6ce4c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 405
            };
        }
    }
}
