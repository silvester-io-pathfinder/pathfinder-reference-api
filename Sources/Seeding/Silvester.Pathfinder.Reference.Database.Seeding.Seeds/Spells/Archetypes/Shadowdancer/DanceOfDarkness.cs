using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DanceOfDarkness : Template
    {
        public static readonly Guid ID = Guid.Parse("ba732791-2d6e-4ad6-9db6-f77df7c0bdb8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dance of Darkness",
                Level = 5,
                Duration = "Varies.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6d85f64a-7bd1-46e3-a425-9944037eba3f"), Type = TextBlockType.Text, Text = "You dance, Striding up to half your Speed. At either the start or end of your Stride, you create an area of magical darkness in a 10-foot burst centered on your location. This area is filled with magical darkness that works the same way as that created by a darkness spell of the same level. When you create the darkness, attempt a Performance check to dance, with a standard DC for your level, to determine the duration of the darkness." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("a1e3c803-f202-4411-8fcd-80b0535b1b41"), 
                CriticalSuccess = "1 minute.",
                Success = "2 rounds.",
                Failure = "1 round."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9e078b53-03fd-424a-a1a4-4ab2870b2039"), Traits.Instances.Darkness.ID);
            builder.Add(Guid.Parse("b21c98bb-7d28-4107-b47d-10ec376316f8"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3896b3e-4870-4cb2-b0a4-7b69f0ac8533"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 193
            };
        }
    }
}
