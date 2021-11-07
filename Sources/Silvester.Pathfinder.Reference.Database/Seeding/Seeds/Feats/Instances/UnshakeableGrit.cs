using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnshakeableGrit : Template
    {
        public static readonly Guid ID = Guid.Parse("6034f1d9-48ce-4bb5-8bcb-3b6ca0b27be0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unshakeable Grit",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8a5e842-453f-49ca-a9c8-c10000c45c57"), Type = TextBlockType.Text, Text = "You’ve become hardened by conflict after everything you’ve faced, and you possess a certain intractable stubbornness. If the reroll granted to you by your (feat: Grit and Tenacity) reaction is a success, you get a critical success instead; if it’s a critical failure, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4591dbea-2d3c-496f-b881-ee57be964491"), Feats.Instances.GritAndTenacity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5abe0928-b3dd-49bb-9058-da7c3b0263de"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
