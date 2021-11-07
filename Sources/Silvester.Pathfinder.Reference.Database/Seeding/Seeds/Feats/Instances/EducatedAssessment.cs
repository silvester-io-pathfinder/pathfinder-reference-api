using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EducatedAssessment : Template
    {
        public static readonly Guid ID = Guid.Parse("2c863a1f-f99b-40ef-a040-7348b04b5d04");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Educated Assessment",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9150f31-edd8-4b5c-b331-5fad9686481d"), Type = TextBlockType.Text, Text = "You attempt to (action: Recall Knowledge) about a creature, and the GM uses the same secret roll result against the creature’s Deception or Stealth DC, giving you the information from a (feat: Battle Assessment). You might get a different degree of success on the (action: Recall Knowledge) check than what you get for the (feat: Battle Assessment). If you have the (feat: Battle Assessment) feat, you gain the effects of Educated Assessment whenever you (action: Recall Knowledge) (such as with the (feat: Automatic Knowledge) feat)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fbed92ab-cc1e-45d9-ab32-7b928413e56c"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7596c54-bb18-4b74-b014-4fafdfbabbe2"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
