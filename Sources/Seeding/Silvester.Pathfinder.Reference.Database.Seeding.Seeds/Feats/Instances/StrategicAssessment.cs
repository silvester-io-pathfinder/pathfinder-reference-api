using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrategicAssessment : Template
    {
        public static readonly Guid ID = Guid.Parse("60e62935-f41a-43e0-a88b-c10b80ddb91c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strategic Assessment",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2cf6f0c1-cf6c-49c0-a8e8-e73c7e33f396"), Type = TextBlockType.Text, Text = $"You learn your foes' strengths and weaknesses by watching them move. When you critically hit a creature with a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} on which you substituted your attack roll due to {ToMarkdownLink<Models.Entities.Feat>("Devising a Stratagem", Feats.Instances.DeviseAStratagem.ID)}, the GM chooses one of the following pieces of information about the enemy to tell you." };
            yield return new TextBlock { Id = Guid.Parse("f433d5d0-d27e-4abe-8f84-eca2d03eeb3a"), Type = TextBlockType.Enumeration, Text = $" : Which of the enemy's weaknesses is highest." };
            yield return new TextBlock { Id = Guid.Parse("773e814b-a2ee-4d90-a3bf-764eec72b98d"), Type = TextBlockType.Enumeration, Text = $" : Which of the enemy's resistances is highest." };
            yield return new TextBlock { Id = Guid.Parse("1ad45c97-6627-411a-a31d-946faf30722d"), Type = TextBlockType.Enumeration, Text = $" : Which of the enemy's saving throws is lowest." };
            yield return new TextBlock { Id = Guid.Parse("c63be916-5d53-42f9-8b1a-e3b5115789eb"), Type = TextBlockType.Enumeration, Text = $" : One immunity the enemy has." };
            yield return new TextBlock { Id = Guid.Parse("f1e1fa37-c6e7-4e6d-9f10-e5aa679df735"), Type = TextBlockType.Text, Text = $"The GM can choose deliberately or at random, but they can't choose information that doesn't apply (such as choosing an immunity for an enemy that has no immunities). This applies only the first time you critically hit a given creature." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fd1c0abc-4719-4569-bb79-7e0b5a413776"), Traits.Instances.Investigator.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("807ab6d1-c71a-4588-b5d5-4a848b1c7f29"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
