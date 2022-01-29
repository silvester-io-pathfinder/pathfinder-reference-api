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
    public class PlayToTheCrowd : Template
    {
        public static readonly Guid ID = Guid.Parse("9a5aa218-dd0c-4376-97ab-418b352897b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Play to the Crowd",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You reduce an enemy to 0 Hit Points during a non-trivial combat encounter with spectators.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6f6f62fa-ba15-4521-90fb-0133a20498d4"), Type = TextBlockType.Text, Text = $"You show off for the crowd. Attempt a Performance check; the DC is determined by the GM but is typically the standard DC for your level or the DC to {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)} on the spectators, whichever is higher. On a success, choose one of the following benefits; on a critical success, choose two benefits:" };
            yield return new TextBlock { Id = Guid.Parse("6a71c391-f064-41ec-81c7-d465d0f4de46"), Type = TextBlockType.Enumeration, Text = $" : A number of temporary Hit Points equal to your character level; these last for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("db8b2a29-5c1e-4e74-90ec-d053bb0b71a1"), Type = TextBlockType.Enumeration, Text = $" : A +1 circumstance bonus to AC until the end of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("af041a07-d12f-412c-b0d6-eb70f824d810"), Type = TextBlockType.Enumeration, Text = $" : A +1 circumstance bonus to your next attack roll before the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ed3c44bd-1c0f-4651-b9c9-e91a1d26f36f"), Feats.Instances.GladiatorDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("288831f0-11b7-4ee6-b856-c8ce308a4d63"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("ead5bce1-62da-460d-b882-737be8fd6019"), Traits.Instances.Concentrate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4285cc38-f5b0-4b11-8981-240564b66771"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
