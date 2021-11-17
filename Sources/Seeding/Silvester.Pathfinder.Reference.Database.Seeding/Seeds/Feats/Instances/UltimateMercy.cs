using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UltimateMercy : Template
    {
        public static readonly Guid ID = Guid.Parse("82a4644a-30b0-4111-9e50-091b557c359b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ultimate Mercy",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fcaa6166-efba-4a70-8fb8-73d8a212f49d"), Type = TextBlockType.Text, Text = "Your mercy transcends the bounds of life and death. When you use (feat: Mercy), you can cast (spell: lay on hands) on a creature that died since your last turn to return it to life. The target returns to life with 1 Hit Point and becomes wounded 1. You can’t use Ultimate Mercy if the triggering effect was (spell: disintegrate) or a (trait: death) effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("03b1f85b-5c38-4afa-ae43-e43a358feb8c"), Feats.Instances.Mercy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53fb95dc-3f47-4dc2-9b15-c9b4ea5bad9f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
