using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MedicDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("2546ccb3-df30-4701-b1cd-abfddf15ef42");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Medic Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you gain two other feats from the medic archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dedfb7e9-aa0a-49b5-9bbc-a529bd36d009"), Type = TextBlockType.Text, Text = "You become an expert in Medicine. When you succeed with (feat: Battle Medicine) or (action: Treat Wounds), the target regains 5 additional HP at DC 20, 10 HP at DC 30, or 15 HP at DC 40. Once per day, you can use (feat: Battle Medicine) on a creature that’s temporarily immune. If you’re a master in Medicine, you can do so once per hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9cc3ef3b-debb-4e69-888f-8bd961d5a4ae"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
            builder.HaveSpecificFeat(Guid.Parse("09729859-f772-4a1c-aadc-61370993dd63"), Feats.Instances.BattleMedicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c44d8bd4-17a6-481f-a80c-1600bcf9b144"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
