using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ClingingIce : Template
    {
        public static readonly Guid ID = Guid.Parse("8a559f6c-9fa7-49d8-bd98-29ff051260cd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Clinging Ice",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d8dbc57-75cb-43cd-b439-c103928f601d"), Type = TextBlockType.Text, Text = "Freezing sleet and heavy snowfall collect on the target's feet and legs, dealing 1d4 cold damage and other effects depending on its Reflex save. Once this spell ends, the target becomes temporarily immune for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f33d1c8e-0182-49d6-ada7-27374ae50b81"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b1db6e08-5de5-41ab-b124-94888f662c89"), Type = TextBlockType.Text, Text = "The damage increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("58e988a4-3ded-4ab8-929d-66b2332d713e"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage.",
                Failure = "The target takes full damage, and takes a –5-foot circumstance penalty to its Speeds until the spell ends.",
                CriticalFailure = "The target takes double damage and a –10-foot circumstance penalty to its Speeds until the spell ends."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("07a9ce47-c132-41d0-9e93-ec2681b3d0e4"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("3f674fd8-6724-4ba0-9e18-1e8fafeb341a"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("13d57a96-6c16-40b3-90b0-fd13fe3a5e7d"), Traits.Instances.Cold.ID);
            builder.Add(Guid.Parse("90207c38-b08f-4066-a699-26bad1965f23"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("8105c49c-3698-4154-a3cd-7fb331b3e7cb"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("5c961e25-9975-4953-b33a-6f935c4e60bd"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b75d20f2-a9d3-477f-8894-5703c34add31"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 237
            };
        }
    }
}
