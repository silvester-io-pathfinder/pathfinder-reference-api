using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ModifyMemory : Template
    {
        public static readonly Guid ID = Guid.Parse("fc4b9cfa-3ce9-4135-a9dc-0314313dfb80");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Modify Memory",
                Level = 4,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Unlimited.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("76accefa-5de2-4591-9ba7-6e195ec309c7"), Type = TextBlockType.Text, Text = "You alter the target’s memories, either erasing a memory, enhancing a memory’s clarity, altering a memory, or adding a false memory. The target can attempt a Will save to resist the spell." };
            yield return new TextBlock { Id = Guid.Parse("57ba153d-ea60-476b-94de-4c339f4601ff"), Type = TextBlockType.Text, Text = "Any memories you’ve altered remain changed as long as the spell is active. If the target moves out of range before the 5 minutes is up, you can’t alter any further memories." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("90915769-b931-4018-888e-654cbad18c18"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ec9d3d41-ba61-4215-a638-27035194f61a"), Type = TextBlockType.Text, Text = "You can cast the spell on a willing target to suppress all memory of a particular topic, detailed in 50 words or fewer. The effect is permanent, and it patches these omissions with an indistinct haze." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ddabf3d4-886e-4c34-a66e-6378e631e5ba"),
                CriticalSuccess = "The target is unaffected and realizes you tried to alter its memory.",
                Success = "The target is unaffected but thinks your spell was something harmless instead of modify memory, unless it identifies the spell.",
                Failure = "During the first 5 minutes of the spell’s duration, you can Sustain the Spell to modify a memory once each round. When you do, you imagine up to 6 seconds of memory to modify, to a maximum of 5 continuous minutes of memory.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb29be37-8b50-49df-8f08-0beda10a0729"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 352
            };
        }
    }
}
