using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TopplingDance : Template
    {
        public static readonly Guid ID = Guid.Parse("28567f41-e718-4a1b-9749-3cf4c18f3197");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Toppling Dance",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("787f4a7c-6197-4cc3-bfeb-82b8f8b517e3"), Type = TextBlockType.Text, Text = $"While sharing a creature's space using {ToMarkdownLink<Models.Entities.Feat>("Dance Underfoot", Feats.Instances.DanceUnderfoot.ID)}, your weapons and unarmed attacks gain the {ToMarkdownLink<Models.Entities.Trait>("trip", Traits.Instances.Trip.ID)} trait, but only against the creature whose space you share. You can be in the same space as a Large or larger prone creature, even if it's not your ally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("54df2abb-7038-4d8f-95fe-888fb63eb189"), Feats.Instances.DanceUnderfoot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79de0b95-3397-44fd-aa03-9788a61ed655"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
