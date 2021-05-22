using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WildMorph : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wild Morph",
                Level = 1,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneOrTwoActions.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You morph your body based on your training, choosing one of the following effects based on your wild order feats." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "If you have Wild Shape, you can morph your hands into wild claws. Your hands transform into incredibly sharp claws. These claws are an unarmed attack you’re trained in and deal 1d6 slashing damage each (agile, finesse). You can still hold and use items with your hands while they’re transformed by this spell, but you cannot hold an item while attacking. If you have Insect Shape, you can instead transform your mouth into wild jaws, an unarmed attack you’re trained in that deals 1d8 piercing damage." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "If you have Elemental Shape, you can morph your body to be partially composed of elemental matter, granting you resistance 5 to critical hits and precision damage." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "If you have Plant Shape, you can morph your arms into long vines, increasing your reach to 10 feet (or 15 feet with a reach weapon)." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "If you have Soaring Shape, you can cast the spell as a two-action activity ([two-actions] somatic, verbal) to grow wings from your back. These wings allow you to fly with a fly Speed of 30 feet." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can choose up to two of the effects from the list. Wild claws leave terrible, ragged wounds that also deal 2d6 persistent bleed damage on a hit, and wild jaws are envenomed, also dealing 2d6 persistent poison damage on a hit." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can choose up to three of the effects from the list. Wild claws deal 4d6 persistent bleed damage on a hit, and wild jaws deal 4d6 persistent poison damage on a hit." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Druid.ID;
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 400
            };
        }
    }
}
