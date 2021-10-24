using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Tanglefoot : Template
    {
        public static readonly Guid ID = Guid.Parse("22b530d2-3cf0-40d3-8833-5c85a8e981d7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tanglefoot",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f947e402-d119-4072-9c0f-491696eb44d3"), Type = TextBlockType.Text, Text = "A vine covered in sticky sap appears from thin air, flicking from your hand and lashing itself to the target. Attempt a spell attack against the target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("49841fa1-9016-4fa5-9eaf-090e0d437f05"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("dc85d258-c9ca-467f-bab8-a5f204383868"), Type = TextBlockType.Text, Text = "The effects last for 2 rounds." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("5138882e-4bc9-42c0-a987-2e76bf0b8974"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("08e15c98-efd7-4268-b153-ff8225afb4bd"), Type = TextBlockType.Text, Text = "The effects last for 1 minute." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("dbb78319-267a-4e77-96b4-2be7660aa0f8"),
                CriticalSuccess = "The target gains the immobilized condition and takes a –10-foot circumstance penalty to its Speeds for 1 round. It can attempt to Escape against your spell DC to remove the penalty and the immobilized condition.",
                Success = "The target takes a –10-foot circumstance penalty to its Speeds for 1 round. It can attempt to Escape against your spell DC to remove the penalty.",
                Failure = "The target is unaffected."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Plant.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("660319a3-835a-4270-9909-2f953741db1c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 377
            };
        }
    }
}
