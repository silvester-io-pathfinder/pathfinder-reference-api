using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrossbowCrackShot : Template
    {
        public static readonly Guid ID = Guid.Parse("69ce61f8-d3f5-4481-bdc4-67a575e1c4f3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crossbow Crack Shot",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1416f33a-1fbc-496a-8c6d-1c7112aeb6d4"), Type = TextBlockType.Text, Text = "You have a deep understanding of the crossbow. When you’re wielding a crossbow and (action: Interact) to reload it, including (action: Interact) actions as part of your slinger’s reload and similar effects, you gain a +2 circumstance bonus to the damage roll on your next (action: Strike) with that crossbow. As normal, this isn’t cumulative with the +1 circumstance bonus from singular expertise. If the crossbow is a simple crossbow, also increase the damage die size for that attack by one step. You must make the attack before the end of your turn or these benefits are lost." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55592009-d152-46dd-9d0f-82660922335e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
