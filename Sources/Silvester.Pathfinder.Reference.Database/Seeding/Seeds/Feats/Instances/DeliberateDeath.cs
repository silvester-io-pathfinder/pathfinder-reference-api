using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeliberateDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("7f5022ba-435c-485a-b1df-27f44422bc03");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deliberate Death",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can select this feat only at 1st level, and you can't retrain into or out of this feat.",
                Trigger = "You are about to gain the dying condition as a result of another creature's attack or ability, and that creature is within your melee reach.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30619f72-91d7-4cd2-8cc1-a527097c554d"), Type = TextBlockType.Text, Text = "Once, you died because someone—murderer or monster, soldier or executioner— chose to strike you down. Just before losing consciousness, make a melee (action: Strike) against the triggering creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93f43b4b-872a-4890-8f55-dee532008c17"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
