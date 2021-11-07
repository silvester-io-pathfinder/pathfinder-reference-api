using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VehicleMechanicDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("308e45dd-4ff7-4b3e-ab81-ad5c80448a26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vehicle Mechanic Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the mechanic archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a7ff8a9-b817-4a2b-aff6-84d442f60802"), Type = TextBlockType.Text, Text = "You are adept at designing and maintaining mechanical vehicles, and you lavish your attention and ingenuity on one vehicle in particular. You become an expert in Crafting, and you choose one vehicle you own—or your party owns collectively—to be your signature vehicle: the vehicle you spend time customizing to grant it various advantages. You can spend 1 week of downtime with a new vehicle to designate it as your signature vehicle instead. Due to your amazing customizations and adjustments, pilots gain a +1 circumstance bonus to any piloting checks they make to control your signature vehicle. If you are a master in Crafting, this bonus increases to +2." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("e04b669d-c4fa-4af2-9b38-ac4a386db009"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("d4e3b212-a345-411c-9ba6-ef9aed88bff1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95f805c7-172f-4ad0-a645-e2fe7b9f7ba2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
