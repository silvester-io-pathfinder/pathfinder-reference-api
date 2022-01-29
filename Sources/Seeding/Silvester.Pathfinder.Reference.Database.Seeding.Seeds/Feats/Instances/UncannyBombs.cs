using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UncannyBombs : Template
    {
        public static readonly Guid ID = Guid.Parse("2fbebc92-6b18-443f-b109-af3422a77547");

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
            yield return new TextBlock { Id = Guid.Parse("9d46462c-b73e-4733-ade8-587ac5a987e3"), Type = TextBlockType.Text, Text = $"You lob bombs unerringly, despite obstructions or distance. When you throw an alchemical item with the {ToMarkdownLink<Models.Entities.Trait>("bomb", Traits.Instances.Bomb.ID)} trait, its range increment increases to 60 feet, you reduce any circumstance bonus to the target's AC from cover by 1, and you automatically succeed at the flat check when targeting a concealed creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7c1a53c0-1ee1-4cd5-9185-80e3d0c5b0ac"), Feats.Instances.FarLobber.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ceb3b01-5626-417a-b761-9fe2076572f4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
