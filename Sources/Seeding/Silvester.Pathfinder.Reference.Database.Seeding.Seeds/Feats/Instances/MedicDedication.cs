using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MedicDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("05ff079d-79ca-4c47-8571-95697f557981");

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
            yield return new TextBlock { Id = Guid.Parse("d20d065d-d026-4a0a-bbae-9bdad5fc9a51"), Type = TextBlockType.Text, Text = "You become an expert in Medicine. When you succeed with (feat: Battle Medicine) or (action: Treat Wounds), the target regains 5 additional HP at DC 20, 10 HP at DC 30, or 15 HP at DC 40. Once per day, you can use (feat: Battle Medicine) on a creature that's temporarily immune. If you're a master in Medicine, you can do so once per hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c9f39933-b236-4eb6-a42a-c9ca0e506bea"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
            builder.HaveSpecificFeat(Guid.Parse("874bb636-8d48-4b70-bc23-8a3776ad9cbc"), Feats.Instances.BattleMedicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05347348-6053-4045-b03f-22cc0c72ce2f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
