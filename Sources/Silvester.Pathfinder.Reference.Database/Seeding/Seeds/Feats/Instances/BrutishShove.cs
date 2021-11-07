using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrutishShove : Template
    {
        public static readonly Guid ID = Guid.Parse("9553d229-7568-4ed3-8463-59b31ecc33f5");

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
            yield return new TextBlock { Id = Guid.Parse("07444b4f-4967-47fc-af3f-8c8151218af0"), Type = TextBlockType.Text, Text = "Throwing your weight behind your attack, you hit your opponent hard enough to make it stumble back. Make a (Action: Strike) with a two-handed melee weapon. If you hit a target that is your size or smaller, that creature is flat-footed until the end of your current turn, and you can automatically (Action: Shove) it, with the same benefits as the (Action: Shove) action (including the critical success effect, if your (Action: Strike) was a critical hit). If you move to follow the target, your movement doesn’t trigger reactions." };
            yield return new TextBlock { Id = Guid.Parse("d2bded7f-584b-4fdc-b5e5-496d4aca1abc"), Type = TextBlockType.Text, Text = "This (Action: Strike) has the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("64b9a94d-96ac-4b98-802c-4a2ea866c024"),
                
                
                Failure = "The target becomes flat-footed until the end of your current turn.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("711df094-ca42-4ba0-b617-39c999bb0007"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
