using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuelingDance : Template
    {
        public static readonly Guid ID = Guid.Parse("c02b2cc7-b900-4734-bc23-6d8cc489ba3d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dueling Dance",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8a9b5576-d80f-4884-9fa7-c20b4ff960a8"), Type = TextBlockType.Text, Text = "Using your free hand as pivot and balance, you both attack and defend with your weapon. While you are in this stance, you constantly have the benefits of (feat: Dueling Parry)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6dc67024-ac39-422c-8bd6-e99dfc2e1643"), Feats.Instances.DuelingParry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08925ab9-3fe0-43e9-ac8f-f6f9f56b4a6d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
