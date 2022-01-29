using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class OneWithTheLand : Template
    {
        public static readonly Guid ID = Guid.Parse("4297095a-7328-457f-ba0e-2d8c7b5c459f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "One with the Land",
                Level = 9,
                Duration = "1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0e6cddb-b4ed-4537-afcc-48e59a9f03e9"), Type = TextBlockType.Text, Text = "You merge with an adjacent natural feature with enough volume to fit you and your worn and held possessions, such as the ground or a large tree. Your merged form is visible within the feature, and creatures can target and attack you normally, though you have cover and can use it to Hide or Take Cover within the feature. You can cast spells while in the feature as long as they don't require line of effect beyond the feature. You can Dismiss the spell. While merged, you gain the following additional benefits." };
            yield return new TextBlock { Id = Guid.Parse("967647f1-2913-43ef-8178-7d3752752f1d"), Type = TextBlockType.Enumeration, Text = "You immediately become aware of the surrounding terrain features, and you gain tremorsense as an imprecise sense with a range of 200 feet." };
            yield return new TextBlock { Id = Guid.Parse("66139aca-bd08-4b1a-b2d6-c1186f793beb"), Type = TextBlockType.Enumeration, Text = "You can make terrain vengeance Strikes by commanding plants, rocks, and other natural features to attack your foes. These are melee Strikes that use your spell attack roll, can target any creature within 60 feet of you, and deal 5d12 bludgeoning, piercing, or slashing damage. You choose the damage type each time you make a terrain vengeance Strike." };
            yield return new TextBlock { Id = Guid.Parse("7704e17e-780b-44a5-a52e-e5f9940cd170"), Type = TextBlockType.Enumeration, Text = "By spending a single action, which has the concentrate trait, you can increase or decrease the environmental temperature changing it to either one step warmer than normal, one step colder than normal, or the normal temperature." };
            yield return new TextBlock { Id = Guid.Parse("d166900b-e91b-4183-aab2-dae4ffbe4fa8"), Type = TextBlockType.Enumeration, Text = "As a 2-action activity that has the concentrate trait, you can create or remove difficult terrain caused by natural terrain in a 20-foot burst within 200 feet." };
            yield return new TextBlock { Id = Guid.Parse("79c97779-303e-4b96-921a-8fb1c29f8fd3"), Type = TextBlockType.Text, Text = "All of your alterations to the land end when the spell ends. Significant physical damage to the natural feature while you are inside it expels you and deals 10d6 damage to you." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a7c28215-2ca8-4dcd-b9b5-1014401bbefe"), Traits.Instances.Earth.ID);
            builder.Add(Guid.Parse("2ca06325-d590-4a8a-9993-956043ac010a"), Traits.Instances.Plant.ID);
            builder.Add(Guid.Parse("4067cfa5-a217-4ce2-b0b1-aa1187e60f25"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ae053af-4c12-478d-afe0-0eeb5df7fb38"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 118
            };
        }
    }
}
