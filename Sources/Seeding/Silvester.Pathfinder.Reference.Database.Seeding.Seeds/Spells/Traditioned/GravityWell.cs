using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{

    public class GravityWell : Template
    {
        public static readonly Guid ID = Guid.Parse("87dcae1a-08bb-467f-b933-6db00d8fbef0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Gravity Well",
                Level = 3,
                Range = "120 feet.",
                Area = "30-foot-radius burst.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7281a69d-c6ee-4867-a450-3529f7cb17d7"), Type = TextBlockType.Text, Text = "You create a sphere of altered gravity. All creatures and unsecured objects in the area move towards the center, depending on their Reflex saving throws. This follows the rules for forced movement. If there's not enough space near the center of the sphere, creatures and objects nearer to the center move first, and others move as far as they can without being blocked, up to the amount set by their saving throw outcomes." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("8a562dc9-4ec8-4366-8390-ccf83bf96971"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature moves 5 feet toward the center.",
                Failure = "The creature moves 15 feet toward the center.",
                CriticalFailure = "The creature moves 30 feet toward the center."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("51100f95-6d6a-4d4c-9de8-1b66ebfe6ffd"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e772658d-0fd5-47f5-8ddf-3f38e82153fb"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 108
            };
        }
    }
}
