using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IronRepercussions : Template
    {
        public static readonly Guid ID = Guid.Parse("8a5d6620-c04a-49d4-9459-30d764900ded");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Iron Repercussions",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("793a4fe3-d2a8-45e1-897f-eefb3bad4b02"), Type = TextBlockType.Text, Text = $"Disobeying your {ToMarkdownLink<Models.Entities.Feat>("Iron Command", Feats.Instances.IronCommand.ID)} has lasting consequences." };
            yield return new TextBlock { Id = Guid.Parse("373ce4c3-94cf-4252-b6fa-9b89e3238680"), Type = TextBlockType.Text, Text = $"If an enemy refuses to kneel to you, you can deal persistent mental damage instead of normal mental damage. You must decide whether the mental damage will be persistent before your enemy chooses whether to kneel or not. The amount of damage is unchanged." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("d32b277a-cc2b-4d5b-9234-b31d3c17c68e"), Causes.Instances.Tyrant.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bea87b42-f8a8-4ffd-ac6c-4c6e6e5e79b7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
