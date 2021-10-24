using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Ventriloquism : Template
    {
        public static readonly Guid ID = Guid.Parse("20c4195e-1a05-4f56-9128-cfe66887f95c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ventriloquism",
                Level = 1,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5dc678cb-ff9a-474f-bc06-d6e19324f79e"), Type = TextBlockType.Text, Text = "Whenever you speak or make any other sound vocally, you can make your vocalization seem to originate from somewhere else within 60 feet, and you can change that apparent location freely as you vocalize. Any creature that hears the sound can attempt to disbelieve your illusion." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("8c388f53-394f-46f0-b797-3ff02f9de5ff"), 
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("edb4e96d-2949-4309-9cb0-f475438fde22"), Type = TextBlockType.Text, Text = "The spell’s duration increases to 1 hour, and you can also change the tone, quality, and other aspects of your voice. Before a creature can attempt to disbelieve your illusion, it must actively attempt a Perception check or otherwise use actions to interact with the sound." }
                }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35ee679a-4b11-4944-9130-855aab7214fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 381
            };
        }
    }
}
