using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpeditiousInspection : Template
    {
        public static readonly Guid ID = Guid.Parse("7189f427-3866-45db-bcfa-da7dc548147a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expeditious Inspection",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5829dc66-2db2-4466-bc91-d87e2b0f2573"), Type = TextBlockType.Text, Text = "You observe and assess your surroundings with great speed. You (action: Recall Knowledge), (action: Seek), or (action: Sense Motive)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32f3e6cf-7a84-4909-bceb-35536281e8da"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
