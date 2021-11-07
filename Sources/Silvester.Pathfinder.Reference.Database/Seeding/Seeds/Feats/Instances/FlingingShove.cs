using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlingingShove : Template
    {
        public static readonly Guid ID = Guid.Parse("77fbaa69-dd55-4e8e-b3a4-1337d5779eec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flinging Shove",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be459753-c9c8-4244-a922-5d84b04f0505"), Type = TextBlockType.Text, Text = "Increase the distance you (Action: Shove) your opponent with (Feat: Aggressive Block) or (Feat: Brutish Shove) to 10 feet on a success or 20 feet on a critical success. When you use (Feat: Aggressive Block), you can choose whether the target is flat-footed or (Action: Shoved | Shove)." };
            yield return new TextBlock { Id = Guid.Parse("64696db9-54d8-4709-b8f2-49921a86dceb"), Type = TextBlockType.Text, Text = "When you make a (Feat: Brutish Shove), you also (Action: Shove) the target 5 feet on a failure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("99461281-8d75-4897-9315-48efbfbec1b2"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("ea63d5ca-6e4d-4840-911e-2f6982283cc3"), Feats.Instances.AggressiveBlock.ID);
                or.HaveSpecificFeat(Guid.Parse("4a8621c8-7f6d-4b39-bc86-f1d83e5c4c26"), Feats.Instances.BrutishShove.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49a96695-c209-41f5-abcf-e736118f544a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
