using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VivaciousBravado : Template
    {
        public static readonly Guid ID = Guid.Parse("cf308cc6-4bf1-412b-8c16-e704010d3bea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vivacious Bravado",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("18e44ec2-f928-4683-babf-acff0cdfad34"), Type = TextBlockType.Text, Text = "Your ego swells, granting you a temporary reprieve from your pain. You gain temporary Hit Points equal to your level plus your Charisma modifier that last until the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c60d1e8b-56cd-44b9-9c63-7275f51bf383"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
