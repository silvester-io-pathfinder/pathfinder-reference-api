using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SloughSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Slough Skin",
                Level = 2,
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You continually and harmlessly slough off the top layer of your skin while new skin regenerates immediately, quickly moving damaging substances away from your body. The flat check to remove persistent damage from effects that coat your skin (such as most persistent acid damage) is reduced to 5, and you gain a +2 status bonus to your initial save against contact poison (but not to further saves, since by that point, the toxin has already entered your system). If you’re suffering from an effect other than persistent damage that depends on continuous contact with your skin, if that effect allows a saving throw, you receive a new saving throw against that effect at the end of each turn when you attempt your flat checks against persistent damage, and you also receive a +2 status bonus to those saving throws." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While affected by this spell, your continually shedding skin makes you much easier to Track. Anyone Tracking you gains a +2 circumstance bonus to do so, and you cannot Hide Your Tracks." };
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 110
            };
        }
    }
}
