using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SoothingBlossoms : Template
    {
        public static readonly Guid ID = Guid.Parse("ea11c7d8-3c50-4d06-9312-a9c258363c33");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Soothing Blossoms",
                Level = 3,
                Range = "30 feet.",
                Duration = "10 minutes.",
                Area = "10-foot burst.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4daee942-2b3b-4d3f-9a43-11496ad1d2ca"), Type = TextBlockType.Text, Text = "Blossoms grow from the ground in a small area, soothing away afflictions and persistent pains and harm. When any creature in that area rolls a successful save against a poison or disease effect, it gets a critical success instead. The blossoms grant assisted recovery to everyone in the area to end their persistent damage, both when the spell is cast and at the start of each of your turns." };
            yield return new TextBlock { Id = Guid.Parse("692d8ae0-3f06-4218-b31e-4cd8e1b5757e"), Type = TextBlockType.Text, Text = "Once the duration ends, the flowers lose their magical effect, but a few of them might survive in the area as long as they can naturally. This spell doesn't give a benefit on a save against an affliction unless the stage lasts 10 minutes or less." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c36579f3-a0ee-47d4-915e-444498ae05ff"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("df448a3d-55ec-4678-b947-d270cf951b67"), Traits.Instances.Plant.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fee10a0f-32da-4ad4-9697-006e561b1ad8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 129
            };
        }
    }
}
