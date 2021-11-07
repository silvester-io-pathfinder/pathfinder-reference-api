using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PartingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("2f7cd9be-34c4-4c65-b643-2ef228a3b599");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Parting Shot",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ce47e22-d531-49c5-b6c8-012c49a3913c"), Type = TextBlockType.Text, Text = "You jump back and fire a quick shot that catches your opponent off guard. You (action: Step) and then make a ranged (action: Strike) with the required weapon. Your target is flat-footed against the attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc269f05-d75a-424e-bde9-245f84f20e18"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
