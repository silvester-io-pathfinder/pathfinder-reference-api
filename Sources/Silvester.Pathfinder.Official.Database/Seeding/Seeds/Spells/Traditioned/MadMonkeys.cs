using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class MadMonkeys : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mad Monkeys",
                Level = 3,
                Range = "30 feet.",
                Area = "5-foot burst.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Magical monkey spirits fill the area as they pile and climb on top of one another. Because the monkeys are magical spirits, they can’t be attacked or hurt. Casting calm emotions or a similar effect over the monkeys makes them docile, causing them to cease making mischief for the duration of mad monkeys." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Choose the kind of mischief your monkeys make when you Cast the Spell. They produce the effect listed for that mischief when you Cast the Spell and each round when you Sustain the Spell. When you Sustain the Spell, you can move the area of the monkeys by 5 feet." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Flagrant Burglary - The monkeys try to Steal any one item from one creature in the area. Use your spell DC – 10 as the monkeys’ Thievery modifier. Their attempt relies more on distraction than subtlety, so the victim knows what item the monkeys were trying to take and whether it was taken. Getting a stolen item from the monkeys— even for the caster—requires Stealing it from them or Disarming them, using your spell DC. When the spell ends, any stolen items fall to the ground in any square of the spell’s area you choose." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Raucous Din - The monkeys screech loudly, potentially deafening creatures in the spell’s area. Each creature in the spell’s area must attempt a Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Tumultuous Gymnastics - The monkeys jump and climb all over creatures in the spell’s area, interfering with complex movements. Each creature in the spell’s area must attempt a Reflex save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse(""),
                Name = "Raucous Din",
                CriticalSuccess = "The creature is unaffected and is temporarily immune for 10 minutes.",
                Success = "The creature is unaffected.",
                Failure = "The creature is deafened for 1 round.",
                CriticalFailure = "The creature is deafened for 1 minute."
            };

            yield return new RollableEffect
            {
                Id = Guid.Parse(""),
                Name = "Tumultuous Gymnastics",
                CriticalSuccess = "The creature is unaffected and is temporarily immune for 10 minutes.",
                Success = "The creature is unaffected.",
                Failure = "For 1 round, the creature must succeed at a DC 5 flat check whenever it attempts a manipulate action. If it fails this check, the creature loses that action.",
                CriticalFailure = "As failure, but the monkeys cling to the creature tenaciously, and the effect lasts until the spell ends, even if the creature leaves the spell’s area."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 222
            };
        }
    }
}
