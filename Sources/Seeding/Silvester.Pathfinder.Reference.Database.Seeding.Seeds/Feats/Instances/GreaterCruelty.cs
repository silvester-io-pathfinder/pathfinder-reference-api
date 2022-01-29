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
    public class GreaterCruelty : Template
    {
        public static readonly Guid ID = Guid.Parse("879e2d43-7577-4c69-b4ca-f105dee0e6ca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Cruelty",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d545130c-5fa8-4a51-878f-271f358a7d4d"), Type = TextBlockType.Text, Text = $"The extent of the corruption within you does more than simply sap your foes' strength, it devastates their minds and reflexes. When you use {ToMarkdownLink<Models.Entities.Feat>("Cruelty", Feats.Instances.Cruelty.ID)}, choose whether you want to make the creature enfeebled as normal, to make it clumsy 1 on a failed save (clumsy 2 on a critical failure), or to make it stupefied 1 on a failed save (stupefied 2 on a critical failure)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ad560603-19da-4cd8-bdc1-68ab18e2b982"), Feats.Instances.Cruelty.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b835448-37f3-4c21-bc69-b39ae7c9820c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
