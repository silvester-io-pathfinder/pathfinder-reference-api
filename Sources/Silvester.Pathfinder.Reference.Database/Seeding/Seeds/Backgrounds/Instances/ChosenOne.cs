using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class ChosenOne : Template
    {
        public static readonly Guid ID = Guid.Parse("d377435d-ba0c-40c6-b0cb-deac1c4dcdf4");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Chosen One",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e8274903-d289-47a5-8e56-5da1db75aa2d"), Type = TextBlockType.Text, Text = "Your birth has fulfilled a prediction, and people close to you are counting on you to do great things. There's intense pressure on you to be up to the task, and the fickle nature of prophecy complicates your path." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainAnyProphecy(Guid.Parse(""));
            builder.GainAnySkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, "The chosen skill must be related to the prophecy.");
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.FortuneTelling.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("844e15d7-a9ee-4e32-bac0-dc8d8705ca46"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 30
            };
        }
    }
}
