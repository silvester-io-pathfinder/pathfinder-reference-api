using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FortuitousShift : Template
    {
        public static readonly Guid ID = Guid.Parse("5ab802e9-f41b-4cb2-9d87-14ab3ca17e53");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fortuitous Shift",
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
            yield return new TextBlock { Id = Guid.Parse("15dae20a-bc91-4213-9375-b68c2bb2a123"), Type = TextBlockType.Text, Text = "You have grown more comfortable with your penchant for supernatural disappearance. The flat check DC of your (feat: Unexpected Shift) feat decreases to 11, and you are no longer dazzled if you succeed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b4ddffb4-0617-4d6a-b842-dde1d0a0a9c1"), Feats.Instances.UnexpectedShift.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("093dcbab-0ee1-4eb5-adf6-8718757ca2a4"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
