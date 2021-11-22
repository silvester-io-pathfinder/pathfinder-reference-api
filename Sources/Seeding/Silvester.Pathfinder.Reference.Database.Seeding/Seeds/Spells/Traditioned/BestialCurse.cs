using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BestialCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("8aa48e8c-3054-445f-93e4-d45c5f8dfce3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Bestial Curse",
                Level = 4,
                Range = "Touch.",
                Duration = "Varies.",
                Targets = "1 living humanoid.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4dd1a06e-ad32-4b9f-9c1d-16b8848c1033"), Type = TextBlockType.Text, Text = "You tap into the target's inner being and curse it to become a bestial version of itself. The effect is based on its Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("0e84ac8e-2c42-4bab-9493-9d3622462f91"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target's body gains minor bestial features. Its insides churn as they partially transform, causing it to be clumsy 1 for 1 round. When it recovers from the clumsy condition, its features revert to normal and the spell ends.",
                Failure = "The target transforms into a bestial form for 1 hour. The target becomes clumsy 1 and gains weakness 1 to silver. It gains a claw, hoof, horn, or jaws Strike (your choice) that uses the target's unarmed Strike statistics except that the damage type changes to bludgeoning, piercing, or slashing, as appropriate. Whenever the target attempts to use any manipulate action, it must succeed at a DC 5 flat check or the action is lost.",
                CriticalFailure = "As failure, but the duration is unlimited."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90746244-d365-44a0-9c64-8e6d41c79051"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 215
            };
        }
    }
}
