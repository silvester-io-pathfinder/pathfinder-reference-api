using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SprayOfStars : Template
    {
        public static readonly Guid ID = Guid.Parse("849ede9e-7dd9-434e-89e7-a2f10636bb08");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spray of Stars",
                Level = 1,
                Area = "15-foot cone.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f6a06002-c567-4c5d-8133-dbed8a879807"), Type = TextBlockType.Text, Text = "You fling a spray of tiny shooting stars, dealing 1d4 fire damage. Each creature in the area must attempt a Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b7092efb-af3b-4392-9b20-956b20e75ab3"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4e39b45d-c1ec-4247-824b-b2d33d08fc41"), Type = TextBlockType.Text, Text = "Increase the damage by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("86e51afa-81ff-42ec-afb2-5bd6265ac87e"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage and is dazzled for 1 round.",
                Failure = "The creature takes full damage and is dazzled for 3 rounds.",
                CriticalFailure = "The creature takes double damage and is dazzled for 1 minute."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a4fcb674-b1a4-4f3a-844b-62e9e29fa8eb"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b2aec7be-6b4f-4dec-8b46-0fe7e9ca8d5d"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("bc164ef8-2e34-40d0-8c6e-597e514c3b32"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("f6a3c615-dc05-40e8-891b-b46d5dec5804"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("41721db1-1abe-42d8-b208-d6b83d124349"), Traits.Instances.Light.ID);
            builder.Add(Guid.Parse("b230e642-7c72-4524-ad63-9aff0c6f2ca6"), Traits.Instances.Oracle.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20819c9a-def4-4faa-86fc-65e461b2fcff"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 233
            };
        }
    }
}
