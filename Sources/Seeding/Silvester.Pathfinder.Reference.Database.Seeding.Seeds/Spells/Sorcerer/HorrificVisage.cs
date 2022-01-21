using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("77cf7a8f-6a50-49ed-8acf-f5244f45d76a"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7253c9d6-3695-4776-b674-8cc9e27f2936"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("2b91ffd1-46f8-43c8-b001-6de67c49cd74"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("3c7220d9-b05e-42aa-bf22-f5df35305ece"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("1d26aa1f-a761-480c-9016-6798b21c005f"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("8e4ac6ff-680d-43f0-a083-1995d4fc0618"), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse("36606ef0-6645-495c-8ade-29e37e051963"), Traits.Instances.Visual.ID);
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
