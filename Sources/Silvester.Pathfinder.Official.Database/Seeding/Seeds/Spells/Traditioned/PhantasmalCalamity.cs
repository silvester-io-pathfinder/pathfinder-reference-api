using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PhantasmalCalamity : Template
    {
        public static readonly Guid ID = Guid.Parse("5c1a1d48-2a29-441a-b29b-d43a93905e6d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Phantasmal Calamity",
                Level = 6,
                Range = "500 feet.",
                Area = "30-foot burst.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bdee741a-5916-4dca-9699-1dbdabc86607"), Type = TextBlockType.Text, Text = "A vision of apocalyptic destruction fills the mind of each creature in the area. The vision deals 11d6 mental damage (basic Will save). On a critical failure, the creature must also succeed at a Reflex save or believe it’s trapped (stuck in a fissure, adrift at sea, or some other fate in keeping with its vision). If it fails the second save, it’s also stunned for 1 minute. It can attempt a new Will save at the end of each of its turns, and on a success, it disbelieves the illusion and recovers from the stunned condition." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c44725cc-2752-43d1-b1bd-7cc01d0a5b24"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b3aec992-3170-4ec5-ba5c-519252d96a14"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("09699cce-25fe-41dc-a3a6-d00be2129dab"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 357
            };
        }
    }
}
