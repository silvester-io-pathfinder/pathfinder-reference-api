using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AnimalVision : Template
    {
        public static readonly Guid ID = Guid.Parse("9ebcaed3-689b-4886-939d-a8b0399180c5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Animal Vision",
                Level = 3,
                Range = "120 feet.",
                CastTime = "1 minute.",
                Duration = "1 hour.",
                Targets = "1 animal.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c34b4717-1df9-49f9-9da9-2f91e2891167"), Type = Utilities.Text.TextBlockType.Text, Text = "You tap into the target’s senses, allowing you to see, hear, and otherwise sense whatever it senses for the spell’s duration.If the target wishes to prevent you from doing so, it can attempt a Will save, negating the spell on a success, but most animals don’t bother to do so.While tapping into the target’s senses, you can’t use your own body’s senses, but you can change back and forth from your body’s senses to the target’s senses using a single action, which has the concentrate trait." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62fd38d8-79bf-47d8-ab9f-13809de3f74c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 318
            };
        }
    }
}
