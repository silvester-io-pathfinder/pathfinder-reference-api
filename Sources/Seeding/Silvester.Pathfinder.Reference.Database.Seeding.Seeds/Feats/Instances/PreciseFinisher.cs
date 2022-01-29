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
    public class PreciseFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("da911e8c-2695-4c31-b197-34f10beb45f9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Precise Finisher",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c7376b35-c07c-46ce-b18c-843cc21323aa"), Type = TextBlockType.Text, Text = $"Even when your foe avoids your {ToMarkdownLink<Models.Entities.Feat>("Confident Finisher", Feats.Instances.ConfidentFinisher.ID)}, you can still hit a vital spot. On a failure with {ToMarkdownLink<Models.Entities.Feat>("Confident Finisher", Feats.Instances.ConfidentFinisher.ID)}, you apply your full precise strike damage instead of half." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b80f56c2-aaaf-4c0b-bec0-f48c0909a47c"), Feats.Instances.ConfidentFinisher.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcd1f7af-6df5-4215-98d8-5fa4a20c085e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
