using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class StumblingCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("73b2e2c2-1cd5-472d-8cfa-480c8bc7fccc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Stumbling Curse",
                Level = 1,
                Range = "60 feet.",
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f2f25803-f5f2-4dd8-8447-fd763c428f60"), Type = TextBlockType.Text, Text = "With a twist of a finger, you send a creature careening on a haphazard trajectory. The target must attempt a Reflex save." };
        }
        
        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("4a14ea7d-dbe5-441b-85ff-5478a9768796"),
                CriticalSuccess = "The creature is unaffected",
                Success = "The target takes a �2 status penalty to Athletics and Acrobatics checks.",
                Failure = " As success, and each time the target Strides, it uses the first 5 feet of movement of the Stride to move 5 feet in a random direction (this is forced movement). This has no effect on a creature with only 5 feet of movement.",
                CriticalFailure = "As failure, except you control the direction of the target's first 5 feet of movement of the Stride."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("df7358fd-5a1e-4e5c-8719-594d96903662"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ed7c0636-88cd-4d14-8ba3-48cf8dc6b791"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("e38021b6-75f4-46e3-86d1-883a77c7371f"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("8566760e-aa9d-4bac-a964-2c40f141e135"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("4bac327f-f949-4203-95f1-f4cdf4bb23df"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff2958c0-8209-4db3-a351-ad6210ff3a9c"),
                SourceId = Sources.Instances.Pathfinder169.ID,
                Page = 75
            };
        }
    }
}
