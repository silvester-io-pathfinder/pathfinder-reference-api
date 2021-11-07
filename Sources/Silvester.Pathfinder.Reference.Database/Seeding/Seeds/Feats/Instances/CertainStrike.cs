using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CertainStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("b97c84c5-db16-4773-8b55-b53a25cff9f1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Certain Strike",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cb301580-d7a5-4ea0-8ae1-accf823205fb"), Type = TextBlockType.Text, Text = "Even when you don’t hit squarely, you can still score a glancing blow. Make a melee (Action: Strike). It gains the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("3487809f-c350-4214-b080-5f43f0170534"),
                
                
                Failure = "Your attack deals any damage it would have dealt on a hit, excluding all damage dice. (This removes damage dice from weapon runes, spells, and special abilities, in addition to weapon damage dice.)",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70e14cda-527c-4107-a152-33898f3a4bb6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
