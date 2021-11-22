using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrutishShove : Template
    {
        public static readonly Guid ID = Guid.Parse("37352e20-263c-4bf4-9cb6-bc420a1cba91");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brutish Shove",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c3cf5ae8-8aeb-4265-9c75-4084521954e4"), Type = TextBlockType.Text, Text = "Throwing your weight behind your attack, you hit your opponent hard enough to make it stumble back. Make a (Action: Strike) with a two-handed melee weapon. If you hit a target that is your size or smaller, that creature is flat-footed until the end of your current turn, and you can automatically (Action: Shove) it, with the same benefits as the (Action: Shove) action (including the critical success effect, if your (Action: Strike) was a critical hit). If you move to follow the target, your movement doesn't trigger reactions." };
            yield return new TextBlock { Id = Guid.Parse("6ede90ce-f7ac-4b0c-a8b3-98168aa0a3d6"), Type = TextBlockType.Text, Text = "This (Action: Strike) has the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("4bb2f77f-5b2d-4615-a302-a4dd0d8bd5f3"),
                
                
                Failure = "The target becomes flat-footed until the end of your current turn.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9a01e6e-4ed8-4344-b2aa-d3e31f4f6f1f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
