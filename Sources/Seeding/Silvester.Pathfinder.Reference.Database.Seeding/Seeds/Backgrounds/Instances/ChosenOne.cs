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
            builder.AddOr(Guid.Parse("7dd1e4d6-78ff-4d54-9ca4-ab20a441cac2"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("7b120934-56fe-48d5-9328-b05aa6b8305e"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("7ab22d42-7d1e-4984-bcfb-c560410a7ce3"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("89147d20-4875-4278-87ec-9bc9273c84f2"));
            builder.GainAnyProphecy(Guid.Parse("95a6c68c-b16b-4d64-95f4-bf876300b600"));
            builder.GainAnySkillProficiency(Guid.Parse("8b4a1b95-4875-4d69-bdb1-cd4fa340f95f"), Proficiencies.Instances.Trained.ID, "The chosen skill must be related to the prophecy.");
            builder.GainSpecificLoreProficiency(Guid.Parse("172d5018-8f03-40ad-b9ef-a24bfa7cc22c"), Proficiencies.Instances.Trained.ID, Lores.Instances.FortuneTelling.ID);
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
