using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CascadeCountermeasure : Template
    {
        public static readonly Guid ID = Guid.Parse("566864ce-3cb9-48bb-b4f3-e1341fa325bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cascade Countermeasure",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a40fa9eb-9e44-4a0f-9f2f-e24db7deb77d"), Type = TextBlockType.Text, Text = "When in Arcane Cascade, you can make yourself resistant to magic. You learn the (spell: cascade countermeasure) conflux spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d3a53e23-08bb-40a4-a21f-9a17f4ff9f8c"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveFocusPool(Guid.Parse("8dff4e09-4cb0-4f15-afa4-f47a9f915872"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63fba10b-830e-411b-925a-d7d653242cc6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
