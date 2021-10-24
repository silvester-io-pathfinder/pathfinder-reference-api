using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FamiliarsFace : Template
    {
        public static readonly Guid ID = Guid.Parse("8da6f3ae-84ed-48d2-b86c-89cbb90f0576");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Familiar's Face",
                Level = 3,
                Range = "1 mile.",
                IsDismissable = true,
                Duration = "Sustained.",
                Targets = "1 willing creature that is your animal companion or familiar.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8e522316-d9c5-4f54-b3a8-a76e3513db65"), Type = TextBlockType.Text, Text = "The target becomes a scrying sensor, allowing you to see through its eyes, smell what it smells, and similarly use its other senses. If you can cast a spell with the revelation trait that affects your senses, such as see invisibility, while this spell is active, you gain the benefit of the spell through the target’s senses instead of your own. You can also speak through the target, with a voice much like yours, though it takes on some of the timbre and character of the target’s growls or squawks. You can use Command an Animal on the target as part of Sustaining this Spell. You don’t need line of sight or line of effect to your target when you Cast this Spell." };
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
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Scrying.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ad65428-881c-4044-983d-81a0bace4cde"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 218
            };
        }
    }
}
