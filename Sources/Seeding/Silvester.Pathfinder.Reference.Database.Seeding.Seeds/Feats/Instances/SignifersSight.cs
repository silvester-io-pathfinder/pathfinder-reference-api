using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SignifersSight : Template
    {
        public static readonly Guid ID = Guid.Parse("7ad440dc-f810-467e-8a30-2bab71785bf9");

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
            yield return new TextBlock { Id = Guid.Parse("197d3ea1-49ca-44bf-97b6-a3ed7cbf8031"), Type = TextBlockType.Text, Text = $"The magic flowing through your signifer's mask allows you to see in the dark, and the mask dampens the distraction caused by sudden flashes of bright light. While wearing your signifer's mask, you gain darkvision. Additionally, if you are dazzled while wearing your signifer's mask and the target is concealed only because you are dazzled, you reduce the flat check DC to target that creature from 5 to 3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3de2748f-275c-4874-9b07-5a3635cc3713"), Feats.Instances.HellknightSigniferDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f61eb3b-1328-408a-879e-ec60e7ea1706"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
