using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FocusedJuggler : Template
    {
        public static readonly Guid ID = Guid.Parse("1218075b-9e68-47bc-81c7-d0be16811c7c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Focused Juggler",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95cc1c93-d15f-43cb-bd6b-8c8362a08d55"), Type = TextBlockType.Text, Text = "You continue (feat: Juggling | Juggle) until the end of your next turn. Increase the maximum number of items you can (feat: Juggle) by one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d95bdf04-1ff9-41d9-b031-9d1f01b0ad24"), Feats.Instances.JugglerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67795f68-8b0b-44dc-b1be-69508156c085"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
