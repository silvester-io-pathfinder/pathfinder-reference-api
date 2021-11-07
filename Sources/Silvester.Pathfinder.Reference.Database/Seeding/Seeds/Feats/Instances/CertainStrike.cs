using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CertainStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("0acbef6d-d3da-46bd-b38c-5f350e62d2f9");

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
            yield return new TextBlock { Id = Guid.Parse("6b6389fa-8e33-4e0a-8d09-eef7f074c22b"), Type = TextBlockType.Text, Text = "Even when you don’t hit squarely, you can still score a glancing blow. Make a melee (Action: Strike). It gains the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("9929ce60-4b64-4bb2-bf00-4cc96b23afbf"),
                
                
                Failure = "Your attack deals any damage it would have dealt on a hit, excluding all damage dice. (This removes damage dice from weapon runes, spells, and special abilities, in addition to weapon damage dice.)",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14f8d8f1-39e6-4fec-9bff-6f2602bd89ae"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
