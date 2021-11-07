using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurvivorOfDesolation : Template
    {
        public static readonly Guid ID = Guid.Parse("9de71d5c-ea92-4162-b487-208b9679e9f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Survivor of Desolation",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("921d9b9a-51b8-409d-ae9a-755b00d0da1f"), Type = TextBlockType.Text, Text = "You gain a +2 circumstance bonus to saving throws against unnatural weather events or environmental hazards occurring in blighted or otherwise unnaturally marred regions. If you roll a success on a saving throw against such an effect, you get a critical success instead; if you roll a critical failure, you get a failure instead. This does not apply to unnatural events created or directed by active effects, such as spells that create anomalous weather or hazardous areas." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("274bda1b-3194-4334-8bb0-238685c49d7f"), Feats.Instances.KnightReclaimantDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58d5312a-022d-4ac5-b654-0949d9e7d22b"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
