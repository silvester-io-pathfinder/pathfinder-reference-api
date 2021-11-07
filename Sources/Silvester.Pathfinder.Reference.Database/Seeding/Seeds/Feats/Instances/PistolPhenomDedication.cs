using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PistolPhenomDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("44666b93-7909-44a3-968d-894785a48a9e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pistol Phenom Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained at least two other feats from the pistol phenom archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34666201-db7f-4004-a8a4-94462b6c0d2f"), Type = TextBlockType.Text, Text = "You catch an opponent off-guard by spinning your weapon. You gain the (feat: Pistol Twirl) gunslinger feat, enabling you to (action: Feint) against creatures within your weapon’s first range increment. This otherwise serves as (feat: Pistol Twirl) for the purpose of meeting prerequisites, although as normal, it doesn’t count as another pistol phenom feat for the purpose of meeting Pistol Phenom Dedication’s special entry and taking another archetype. Whenever you (action: Feint) with a one-handed firearm, you can choose to attempt a Performance check instead of a Deception check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("6bf3bc6f-8d04-4c06-b3b0-a1ebcebe36c9"), "Trained in at least one type of one-handed firearm.");
            builder.HaveSpecificSkillProficiency(Guid.Parse("fe426be9-cc29-4d57-b420-50d10faa0251"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("aef3fceb-bafc-4ac1-8dc1-2fc9b689c852"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("221afc36-56d8-476d-ab70-62e0e5b2e113"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
