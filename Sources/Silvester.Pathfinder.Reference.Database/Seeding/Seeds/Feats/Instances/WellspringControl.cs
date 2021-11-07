using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WellspringControl : Template
    {
        public static readonly Guid ID = Guid.Parse("6d79644f-8bc0-4dae-b70c-50835dd34700");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wellspring Control",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0813873c-1b43-476a-a895-f814e1b656da"), Type = TextBlockType.Text, Text = "When you generate a wellspring surge, roll twice on Table 5–2 (SoM pg. 250) and take the result of your choice. This doesn’t apply when you cause another creature to generate a wellspring surge." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("48f1fcdc-7edd-4151-9e7f-2b9870ae5d24"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("397e9121-1846-4a3f-aa35-d53eabe4f74b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
