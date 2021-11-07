using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TangledForestRake : Template
    {
        public static readonly Guid ID = Guid.Parse("c1c435b9-2362-4a49-b468-88a47e52c0da");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tangled Forest Rake",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd28919d-78d7-411e-bd75-dcc62df7b855"), Type = TextBlockType.Text, Text = "You reposition foes with raking attacks. Make a lashing branch (action: Strike). If you hit and deal damage, you force the target to move 5 feet into a space within your reach. This follows the forced movement rules found on page 475." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7fd5d3fc-91be-46e6-8cf9-504bb7992525"), Feats.Instances.TangledForestStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de5d30c0-8700-4975-95e6-673c2066997b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
