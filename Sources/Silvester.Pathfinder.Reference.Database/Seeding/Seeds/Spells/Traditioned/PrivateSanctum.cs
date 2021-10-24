using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PrivateSanctum : Template
    {
        public static readonly Guid ID = Guid.Parse("ba66525f-674c-4658-a4f2-295e2ee6c12f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Private Sanctum",
                Level = 4,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Area = "100-foot burst.",
                Duration = "24 hours.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7a46fed6-33e9-4369-85ba-8e334e33f548"), Type = TextBlockType.Text, Text = "From outside, the area looks like a bank of impenetrable black fog. Sensory stimuli (such as sounds, smells, and light) don’t pass from inside the area to outside the area. Scrying spells can’t perceive any stimuli from the area, and mind-reading effects don’t work in the area." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9941117-53e8-44df-9708-69ef2b30e122"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 360
            };
        }
    }
}
