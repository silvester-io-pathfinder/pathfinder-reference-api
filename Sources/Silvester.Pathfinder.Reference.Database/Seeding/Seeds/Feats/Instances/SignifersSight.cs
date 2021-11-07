using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SignifersSight : Template
    {
        public static readonly Guid ID = Guid.Parse("8ef31364-44a6-48bd-b257-148a2f6ed992");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Signifer's Sight",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f9420df-ade6-4d80-9118-adcf7dd0a175"), Type = TextBlockType.Text, Text = "The magic flowing through your signifer’s mask allows you to see in the dark, and the mask dampens the distraction caused by sudden flashes of bright light. While wearing your signifer’s mask, you gain darkvision. Additionally, if you are dazzled while wearing your signifer’s mask and the target is concealed only because you are dazzled, you reduce the flat check DC to target that creature from 5 to 3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0ac037f9-f379-467a-9fe0-10dc571c551e"), Feats.Instances.HellknightSigniferDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2954ab63-2221-427f-ae21-2ef3cf656a47"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
