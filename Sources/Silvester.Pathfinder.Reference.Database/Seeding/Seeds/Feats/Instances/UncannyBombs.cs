using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UncannyBombs : Template
    {
        public static readonly Guid ID = Guid.Parse("e3d40c70-66cf-489e-8836-432e39ca69dd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Uncanny Bombs",
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
            yield return new TextBlock { Id = Guid.Parse("64f81bd1-36e4-4e1d-a48d-ae31692600a0"), Type = TextBlockType.Text, Text = "You lob bombs unerringly, despite obstructions or distance. When you throw an alchemical item with the (trait: bomb) trait, its range increment increases to 60 feet, you reduce any circumstance bonus to the target’s AC from cover by 1, and you automatically succeed at the flat check when targeting a concealed creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c8f78fb3-e412-4dfa-b3d3-665469cf867f"), Feats.Instances.FarLobber.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f1d2a41-0993-45c6-af76-4c004f63aad0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
