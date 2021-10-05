using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ColorSpray : Template
    {
        public static readonly Guid ID = Guid.Parse("060ba321-f5b9-4ac8-907c-fec7bb740713");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Color Spray",
                Level = 1,
                Area = "15-foot cone.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b9e2dd3a-42e7-4693-afee-fd55fc5c68c5"), Type = Utilities.Text.TextBlockType.Text, Text = "Swirling colors affect viewers based on their Will saves." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect 
            { 
                Id = Guid.Parse("c5391ad6-09cd-42a9-ac94-74f04f4efc97"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is dazzled for 1 round.",
                Failure = "The creature is stunned 1, blinded for 1 round, and dazzled for 1 minute.",
                CriticalFailure = "The creature is stunned for 1 round and blinded for 1 minute."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bfd94044-7ad9-44bc-9b71-d5ff2b0115c5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 324
            };
        }
    }
}
