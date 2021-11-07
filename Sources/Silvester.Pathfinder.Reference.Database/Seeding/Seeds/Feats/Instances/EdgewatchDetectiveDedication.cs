using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EdgewatchDetectiveDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("95f25977-84b5-420e-8132-d67a7bb02026");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Edgewatch Detective Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the this archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5fbd0fd-97cf-4c64-a650-f777fcce5e58"), Type = TextBlockType.Text, Text = "You become trained in Society or Thievery; if you are already trained in both of these skills, you instead become trained in a skill of your choice. You can use Perception instead of Survival to (action: Track), and you gain the (feat: Experienced Tracker) skill feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("95b014f9-1e0a-475b-9b13-ddd06cf66ae1"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("635691a1-2fb9-4b31-a754-0fd9c9d6c12a"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
                or.HaveSpecificStat(Guid.Parse("665b0915-296a-48ea-b312-ec0ee9d907d5"), requiredStatValue: 14, Stats.Instances.Wisdom.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c655279-9cb7-4d06-bc60-905aa8f32df4"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
