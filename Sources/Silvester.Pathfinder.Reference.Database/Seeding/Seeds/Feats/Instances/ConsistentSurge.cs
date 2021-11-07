using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConsistentSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("065a39f4-869e-437a-bc11-8b48d4581e92");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Consistent Surge",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd724bbe-6607-4dd8-8cb4-ff5ed97c3b62"), Type = TextBlockType.Text, Text = "Your nanites are incredibly effective, capable of improving your body’s efficiency regularly. You can use (feat: Nanite Surge) with a frequency of once per 10 minutes, rather than once per hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6d99b05d-e83c-48bb-a95c-dc05a9250093"), Feats.Instances.NaniteSurge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac27d438-73bd-496d-91a5-2ae36d28cc87"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
