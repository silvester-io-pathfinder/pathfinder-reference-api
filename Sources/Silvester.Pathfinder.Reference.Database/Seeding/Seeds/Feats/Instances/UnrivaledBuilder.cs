using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnrivaledBuilder : Template
    {
        public static readonly Guid ID = Guid.Parse("5cb12d61-c0d9-4403-869c-088e5018d9a0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unrivaled Builder",
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
            yield return new TextBlock { Id = Guid.Parse("9679b69c-64ec-4ae3-9369-339e2aa85ecd"), Type = TextBlockType.Text, Text = "Building things is like solving a puzzle, and you know how to use anything at your disposal to get the job done. You gain creation as a 5th-level innate primal spell. You must have an equivalent Bulk of material to create an item, such as wood or scrap metal to make a wheelbarrow. You can cast this spell once each day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2b501129-6137-4b71-8918-783cf42ba5b8"), Feats.Instances.HandyWithYourPaws.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af230991-3606-4ddb-9109-3aab3b7684db"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
