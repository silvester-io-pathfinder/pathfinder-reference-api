using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RangersBramble : Template
    {
        public static readonly Guid ID = Guid.Parse("1995d493-43cd-476a-81ea-8d76076888ff");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ranger's Bramble",
                Level = 3,
                Range = "100 feet.",
                Area = "All squares that contain plants in a 5-foot burst.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ade21048-8486-494e-9484-a769e6747031"), Type = TextBlockType.Text, Text = "You cause plants in the area to entangle your foes, with the effects of entangle. A creature that critically fails the save takes 2d4 persistent bleed damage in addition to being immobilized. Escaping your bramble doesn't end the bleed damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("06cc39e4-fe0d-4a69-8885-a6e133f6bec3"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("acbeba83-784f-48ed-ad79-614618902702"), Type = TextBlockType.Text, Text = "The bleed damage on a critical failure increases by 1d4." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2f24bca6-01b5-44db-95f0-24f630236bc3"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("a6870e74-b656-4af7-a35e-739994f532a8"), Traits.Instances.Plant.ID);
            builder.Add(Guid.Parse("1d25a0a5-dd3b-461b-abe8-41773052c6f9"), Traits.Instances.Ranger.ID);
            builder.Add(Guid.Parse("4e60effd-040a-4d8f-aec2-45c1529c4af5"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("821601f3-661e-4f49-82e7-bc29d24b3f15"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 235
            };
        }
    }
}
