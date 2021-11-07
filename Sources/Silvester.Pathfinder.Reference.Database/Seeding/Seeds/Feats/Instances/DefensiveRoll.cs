using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefensiveRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("c5507b9d-2789-45b8-b6cb-34443f303d12");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defensive Roll",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A physical attack would reduce you to 0 Hit Points.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc8b37e1-5226-4afb-ab8f-e0502de3a9ca"), Type = TextBlockType.Text, Text = "Dropping into a roll to disperse the force of the blow, you can partially evade a lethal attack and stay conscious. You take half damage from the triggering attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17054cb8-7a78-47e1-b324-4d9ff65a2370"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
