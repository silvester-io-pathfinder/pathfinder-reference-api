using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickReversal : Template
    {
        public static readonly Guid ID = Guid.Parse("51101507-f093-42d7-9683-75200c203963");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Reversal",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7bd6d7b-f8ae-4108-905b-c14b88dc5629"), Type = TextBlockType.Text, Text = "You turn your foes’ flanking against them with a quick reverse. Make a melee (Action: Strike) against one of the flanking enemies and make a second (Action: Strike) with the same weapon or unarmed attack against a different enemy that is flanking you. This second (Action: Strike) has the same multiple attack penalty of the initial attack and doesn’t count toward your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c95057a4-6e20-4c33-bd25-a3000723e7b6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
