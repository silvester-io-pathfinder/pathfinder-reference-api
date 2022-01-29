using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedWarding : Template
    {
        public static readonly Guid ID = Guid.Parse("a90d885a-f513-4049-97c5-acdbb3c29c9b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Warding",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df82b719-a800-4872-855a-5c0007089ea6"), Type = TextBlockType.Text, Text = $"You ward your allies from the attacks of your foes whenever you apply those protections to yourself. When you gain a status bonus to AC and saves from {ToMarkdownLink<Models.Entities.Feat>("Esoteric Warden", Feats.Instances.EsotericWarden.ID)}, you can also choose to grant the same benefit to all allies within 30 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ae67a6ce-34af-4137-bc19-5ca074f82bcb"), Feats.Instances.EsotericWarden.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("867daf81-e90f-485d-8db5-f6f9074a8e4a"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
