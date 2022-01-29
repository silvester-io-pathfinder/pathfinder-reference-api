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
    public class OngoingStrategy : Template
    {
        public static readonly Guid ID = Guid.Parse("fbd8c6cb-416a-4948-8bd2-87beb218e0f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ongoing Strategy",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ddcf3b6-f3be-4097-b53e-a52fec476e9a"), Type = TextBlockType.Text, Text = $"You're constantly studying small aspects of everyone's movements, even if you don't have a stratagem in place ahead of time. On any {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} for which you didn't {ToMarkdownLink<Models.Entities.Feat>("Devise a Stratagem", Feats.Instances.DeviseAStratagem.ID)}, you still deal precision damage equal to your number of strategic strike damage dice so long as the weapon or unarmed attack you used is one that would have let you use your Intelligence modifier had you {ToMarkdownLink<Models.Entities.Feat>("Devised a Stratagem", Feats.Instances.DeviseAStratagem.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("f652ed9e-0d2b-4d74-8eac-430c2934fbd5"), ClassFeatures.Investigators.StrategicStrike.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("eb8241da-728f-4fa1-b5da-3f03b7ea289d"), Traits.Instances.Investigator.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8727c64-1d14-4ba9-9fe3-41fd0f33d8f3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
