using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FuriousVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("85c5b0bf-fc67-4259-8b3a-6539f4876826");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Furious Vengeance",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy within your melee reach critically hits you with a melee Strike.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc4ef223-c00a-4660-bde0-3645f744130a"), Type = TextBlockType.Text, Text = "Your enemy’s blow fuels your rage and provokes your immediate retaliation. Make a melee (action: Strike) against the triggering enemy." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("37032b24-90fb-4a19-a320-ae6970038a0f"), Instincts.Instances.Fury.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f72c4b0-7d5d-4f85-8d78-b41ad8a0b0d3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
