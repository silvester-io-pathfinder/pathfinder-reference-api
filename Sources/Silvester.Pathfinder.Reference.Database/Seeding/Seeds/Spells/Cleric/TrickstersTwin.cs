using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TrickstersTwin : Template
    {
        public static readonly Guid ID = Guid.Parse("4842cf39-f574-4e0e-b473-216cb4abfc46");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Trickster's Twin",
                Level = 4,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Trickery.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("da2bfeb6-0f5f-49f0-9acf-b5d6fbcf9104"), Type = TextBlockType.Text, Text = "You rarely settle for being in just one place. Choose a location within 100 feet of the target that the target can see. You create an illusion of yourself there that only it can see and that mimics all your actions. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("0390d36a-cce7-4616-a177-867fea818690"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target believes you’re in the designated location and can’t see you in your actual location. The target automatically disbelieves the illusion when you use an action that doesn’t make sense in the illusion’s position, or if the target attacks, touches, Seeks, or otherwise engages with the illusion. If you use a hostile action against the target, the spell ends.",
                Failure = "As success, but the target must succeed at a Will save to disbelieve the illusion when one of the listed events occurs.",
                CriticalFailure = "As success, but the target must critically succeed at a Will save to disbelieve when one of the listed events occurs."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc6be2db-2b0f-4e2e-84db-c10a3ac7d38b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 398
            };
        }
    }
}
