using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CavaliersBanner : Template
    {
        public static readonly Guid ID = Guid.Parse("00b8494f-7d97-40e9-aff8-a3ced02f4abb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cavalier's Banner",
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
            yield return new TextBlock { Id = Guid.Parse("d0d730fe-964b-486f-b39d-1e24f68bb245"), Type = TextBlockType.Text, Text = $"You fly the banner of your pledge from your mount, raising your allies' spirits. You and all allies within 30 feet gain a +1 circumstance bonus to Will saves and DCs against {ToMarkdownLink<Models.Entities.Trait>("fear", Traits.Instances.Fear.ID)} effects. If your banner is destroyed or removed, allies within 30 feet become frightened 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6a0f1eb2-333a-4aa0-840b-f92a0a7fd388"), Feats.Instances.CavalierDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed47b3a8-762b-4aa9-816f-678ccc4495e0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
