using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GuidingLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("4bcff955-fd80-431a-bbc5-c695e1cb0d85");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Guiding Luck",
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
            yield return new TextBlock { Id = Guid.Parse("f91d7060-e2d0-42f2-ad33-b1a78b2ac67c"), Type = TextBlockType.Text, Text = "Your luck guides you to look the right way and aim your blows unerringly. You can use (Feat: Halfling Luck) twice per day: once in response to its normal trigger, and once when you fail a Perception check or attack roll instead of the normal trigger." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4d1e8fc3-68ac-40a3-8ff7-4de242139393"), Feats.Instances.HalflingLuck.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cdd23da-78ae-4144-bf27-8121922af0ed"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
