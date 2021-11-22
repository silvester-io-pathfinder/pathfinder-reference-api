using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WildMorph : Template
    {
        public static readonly Guid ID = Guid.Parse("b6163b08-508b-4f67-8816-c8887b97575f");

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
            yield return new TextBlock { Id = Guid.Parse("d798f79b-3ddd-4bd6-82e5-288129ab2e1a"), Type = TextBlockType.Text, Text = "You morph your body based on your training, choosing one of the following effects based on your wild order feats." };
            yield return new TextBlock { Id = Guid.Parse("cdefe147-9113-426a-b73a-82d9227ead89"), Type = TextBlockType.Enumeration, Text = "If you have Wild Shape, you can morph your hands into wild claws. Your hands transform into incredibly sharp claws. These claws are an unarmed attack you're trained in and deal 1d6 slashing damage each (agile, finesse). You can still hold and use items with your hands while they're transformed by this spell, but you cannot hold an item while attacking. If you have Insect Shape, you can instead transform your mouth into wild jaws, an unarmed attack you're trained in that deals 1d8 piercing damage." };
            yield return new TextBlock { Id = Guid.Parse("db0f83b1-27eb-4c7c-97bc-fabe2d1c50fa"), Type = TextBlockType.Enumeration, Text = "If you have Elemental Shape, you can morph your body to be partially composed of elemental matter, granting you resistance 5 to critical hits and precision damage." };
            yield return new TextBlock { Id = Guid.Parse("52adf9d1-c371-47d9-b7da-576aeb6e468f"), Type = TextBlockType.Enumeration, Text = "If you have Plant Shape, you can morph your arms into long vines, increasing your reach to 10 feet (or 15 feet with a reach weapon)." };
            yield return new TextBlock { Id = Guid.Parse("fe0e1a99-af43-4076-91a6-12478045749a"), Type = TextBlockType.Enumeration, Text = "If you have Soaring Shape, you can cast the spell as a two-action activity ([two-actions] somatic, verbal) to grow wings from your back. These wings allow you to fly with a fly Speed of 30 feet." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3d9cb393-886d-481a-b33e-1619e6a59395"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("230fd890-1d09-4bdd-8a9e-1083e9a7b9f4"), Type = TextBlockType.Text, Text = "You can choose up to two of the effects from the list. Wild claws leave terrible, ragged wounds that also deal 2d6 persistent bleed damage on a hit, and wild jaws are envenomed, also dealing 2d6 persistent poison damage on a hit." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("f950ba32-efea-4a03-a6e2-c2e857eff0ed"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("faf8a9d0-e8ef-41aa-9ffe-ce59e1702e10"), Type = TextBlockType.Text, Text = "You can choose up to three of the effects from the list. Wild claws deal 4d6 persistent bleed damage on a hit, and wild jaws deal 4d6 persistent poison damage on a hit." }
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
                Id = Guid.Parse("b4b3c515-2245-4f8d-933d-244b97e54961"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 400
            };
        }
    }
}
