using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UltimateMercy : Template
    {
        public static readonly Guid ID = Guid.Parse("6ef55e25-3f9c-41ee-8cf0-4f97ebe49b93");

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
            yield return new TextBlock { Id = Guid.Parse("39273d6d-dd26-4e06-af3b-ea3b7894ba3d"), Type = TextBlockType.Text, Text = "Your mercy transcends the bounds of life and death. When you use (feat: Mercy), you can cast (spell: lay on hands) on a creature that died since your last turn to return it to life. The target returns to life with 1 Hit Point and becomes wounded 1. You can’t use Ultimate Mercy if the triggering effect was (spell: disintegrate) or a (trait: death) effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("765f21d4-e0a4-4f3d-ac53-ab1b2a390cd4"), Feats.Instances.mercy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a6090cf-ae55-4050-ba3d-a940bb5cec46"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
