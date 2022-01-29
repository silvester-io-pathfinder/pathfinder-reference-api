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
    public class ParadoxicalMystery : Template
    {
        public static readonly Guid ID = Guid.Parse("fd3f4391-05f5-4e90-96c5-c603600a392f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Paradoxical Mystery",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db836b8d-c81a-4043-ba52-bd4026d51bab"), Type = TextBlockType.Text, Text = $"The truest depths of your divine mystery are fathomless and contradictory, granting you changing powers that even you can barely begin to fathom. Each day during your daily preparations, choose one basic or advanced domain spell from any domain from the Core Rulebook or another domain to which you have access, or any initial or advanced revelation spell from another mystery. You gain that spell as a revelation spell until your next daily preparations, and it has the {ToMarkdownLink<Models.Entities.Trait>("cursebound", Traits.Instances.Cursebound.ID)} trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e3e9cd52-2d29-4f8a-9e7a-82d1889a23cc"), Feats.Instances.GreaterRevelation.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("944cf971-17a8-4cc9-81f4-dba53c644f20"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
