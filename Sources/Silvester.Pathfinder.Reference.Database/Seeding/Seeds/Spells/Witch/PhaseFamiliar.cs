using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PhaseFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("1fe7d56b-da4a-4c42-9de0-cfbd82fff361");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Phase Familiar",
                Level = 1,
                Trigger = "Your familiar would take damage.",
                Range = "60 feet.",
                Targets = "Your familiar.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bd018b03-581e-4f86-a7c6-3170cb9ee1b6"), Type = TextBlockType.Text, Text = "You draw upon your patron’s power to momentarily shift your familiar from its solid, physical form into an ephemeral version of itself shaped of mist. Your familiar gains resistance 5 to all damage and is immune to precision damage. These apply only against the triggering damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7e6383b5-a678-4333-a26d-09c5716eea42"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("63a70032-3093-4ff8-a4ee-323ed604bdc5"), Type = TextBlockType.Text, Text = "Increase the resistance by 2." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa666a9b-6a13-4d09-80b3-38c39dea07c4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 239
            };
        }
    }
}
