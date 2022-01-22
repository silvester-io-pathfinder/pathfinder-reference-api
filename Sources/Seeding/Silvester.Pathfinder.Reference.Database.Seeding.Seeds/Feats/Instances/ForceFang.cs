using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForceFang : Template
    {
        public static readonly Guid ID = Guid.Parse("2860b0ce-2f27-4f63-93c5-04a2729c5792");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Force Fang",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("069dd447-5bf1-4ae0-b261-6cf91724f9af"), Type = TextBlockType.Text, Text = $"You can turn your attack into an unerring blur of force. You learn the {ToMarkdownLink<Models.Entities.Spell>("force fang", Spells.Instances.ForceFang.ID)} conflux spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFocusPool(Guid.Parse("12140ece-71e3-419f-b656-a3db43e3d646"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3c2343f-9650-4a6d-9fba-0fde538f074e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
