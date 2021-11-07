using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RaconteursReload : Template
    {
        public static readonly Guid ID = Guid.Parse("fe2a6ac8-cd45-45a6-9e2a-e5a4573a2b67");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Raconteur's Reload",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ae0dfa2-8913-4790-9705-eecf7b8e85c0"), Type = TextBlockType.Text, Text = "Your rapid or forceful words draw the enemy’s attention away from your hands long enough to chamber another bullet. (action: Interact) to reload and then attempt a Deception check to (action: Create a Diversion) or an Intimidation check to (action: Demoralize)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("215e7677-cb9e-41d7-8563-9ccf1310de75"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
