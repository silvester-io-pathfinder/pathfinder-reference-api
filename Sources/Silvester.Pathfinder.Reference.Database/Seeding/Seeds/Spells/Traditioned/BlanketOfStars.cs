using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BlanketOfStars : Template
    {
        public static readonly Guid ID = Guid.Parse("757e9c07-44df-4da9-8f1a-746fb2f7b296");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blanket of Stars",
                Level = 6,
                Duration = "10 minutes.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86b509bb-c558-4256-b23e-614ba304fc12"), Type = TextBlockType.Text, Text = "A flowing cloak of utter darkness drapes over you, filled with pinpricks of light like distant stars. It imparts the stillness of the cosmos to you, granting you a +2 status bonus to Stealth checks to Hide and Sneak. While outside under a starry night sky, you’re also invisible as long as you remain still. When moving under a starry night sky, you are concealed instead." };
            yield return new TextBlock { Id = Guid.Parse("c004523f-bccb-4814-ac16-0e8a8eaead8f"), Type = TextBlockType.Text, Text = "Gazing too closely into the stars is disorienting. Any creature that ends its turn adjacent to you must attempt a Will save; this is a mental, visual effect." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("5cee3e8b-6f4f-4578-b8f7-64e4296ef481"),
                Success = "The creature is unaffected.",
                Failure = "The creature is dazzled until the end of its next turn.",
                CriticalFailure = "The creature is confused and dazzled until the end of its next turn."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bb9a39f-c40d-40af-9eb3-03b65497961f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 215
            };
        }
    }
}
