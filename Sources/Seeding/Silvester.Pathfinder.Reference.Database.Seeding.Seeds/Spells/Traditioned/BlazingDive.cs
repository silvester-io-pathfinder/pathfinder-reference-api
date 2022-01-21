using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BlazingDive : Template
    {
        public static readonly Guid ID = Guid.Parse("8f592d68-866f-4bfd-9479-0b0cd09203c6");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blazing Dive",
                Level = 3,
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("932610b0-21ba-43f7-8273-165af6616337"), Type = TextBlockType.Text, Text = "Superheated air collects under you, buoying you high into the sky before you plummet back down in a fiery comet. You Fly 15 feet straight up into the air, then Fly in a straight line to an empty space of your choice on the ground within 60 feet. When you land, the blistering air blasts out from you, dealing 3d4 bludgeoning damage and 3d6 fire damage (basic Reflex save) to all creatures in a 10-foot emanation." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("22825b85-03d8-440d-b0ef-bb74f38962ce"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("aeaaa85b-0502-45ed-b918-000efd7b8271"), Type = TextBlockType.Text, Text = "The damage increases by 1d4 bludgeoning and 1d6 fire." }
                }
            };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7cc08088-ddf8-4367-9b2f-2e3c7287a893"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("a1f2891e-7c6b-4b0d-a70f-ef98cd0710a8"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("f6bc3153-2247-443c-9dc3-86a88f61b92c"), Traits.Instances.Fire.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2bfa125-ba45-4569-9383-ff1055cac714"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 90
            };
        }
    }
}
