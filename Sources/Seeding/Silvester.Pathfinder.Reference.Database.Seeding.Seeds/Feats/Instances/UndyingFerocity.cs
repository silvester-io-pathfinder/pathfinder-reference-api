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
    public class UndyingFerocity : Template
    {
        public static readonly Guid ID = Guid.Parse("7776b7e1-9465-4963-97e0-715397e79898");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Undying Ferocity",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ef17e68-d60d-4e4b-a1d8-59f2078fa113"), Type = TextBlockType.Text, Text = $"You resist death's clutches with supernatural vigor. When you use {ToMarkdownLink<Models.Entities.Feat>("Orc Ferocity", Feats.Instances.OrcFerocity.ID)}, you gain temporary Hit Points equal to your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f4d22a19-61af-49c4-957c-957c759e3479"), Feats.Instances.OrcFerocity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("eabb6efc-e707-4cdd-b6c5-69b0947c257b"), Traits.Instances.Orc.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39e81043-0703-43c3-bc17-65a299be586e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
