using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurvivorOfDesolation : Template
    {
        public static readonly Guid ID = Guid.Parse("7bd79de8-ad85-41e3-87db-e93d88b76c1e");

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
            yield return new TextBlock { Id = Guid.Parse("f132312b-664a-45f2-a7ac-a20d4fb2b92c"), Type = TextBlockType.Text, Text = "You gain a +2 circumstance bonus to saving throws against unnatural weather events or environmental hazards occurring in blighted or otherwise unnaturally marred regions. If you roll a success on a saving throw against such an effect, you get a critical success instead; if you roll a critical failure, you get a failure instead. This does not apply to unnatural events created or directed by active effects, such as spells that create anomalous weather or hazardous areas." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d6374f1e-3b4d-41f7-9ec3-4bdd08280554"), Feats.Instances.KnightReclaimantDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39818a2b-c4de-4117-ad82-2efccc9b3113"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
