using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HorrificVisage : Template
    {
        public static readonly Guid ID = Guid.Parse("4f04b1d5-321d-4271-a93d-6049c64883c8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Horrific Visage",
                Level = 3,
                Area = "30-foot-radius emanation centered on you.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32ef1adb-9aa8-474c-a48d-40c9cf607fac"), Type = TextBlockType.Text, Text = "You briefly transform your features into the horrific visage of a hag, striking fear into your enemies. Foes in the area must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("34f7cced-ce0f-42a2-b44b-719fc9eed9a4"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4337663f-1f76-4a28-8b97-d1c3b755b877"), Type = TextBlockType.Text, Text = "Foes in the area are frightened 1 on a success, frightened 2 on a failure, and frightened 3 and fleeing for 1 round on a critical failure. They are still unaffected on a critical success." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f012fe31-9755-45e7-b53b-3700880cd2b6"),
                Success = "The foe is unaffected.",
                Failure = "The foe is frightened 1.",
                CriticalFailure = "The foe is frightened 2."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Sorcerer.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15900ded-9d8f-4508-ab65-ddb7178bc12a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 405
            };
        }
    }
}
