using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PistolPhenomDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("c24fb56a-e7d3-4529-b6a7-4d6964cb9e40");

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
            yield return new TextBlock { Id = Guid.Parse("8e70b76b-2d2e-419d-8472-c51e38e133e8"), Type = TextBlockType.Text, Text = "You catch an opponent off-guard by spinning your weapon. You gain the (feat: Pistol Twirl) gunslinger feat, enabling you to (action: Feint) against creatures within your weapon’s first range increment. This otherwise serves as (feat: Pistol Twirl) for the purpose of meeting prerequisites, although as normal, it doesn’t count as another pistol phenom feat for the purpose of meeting Pistol Phenom Dedication’s special entry and taking another archetype. Whenever you (action: Feint) with a one-handed firearm, you can choose to attempt a Performance check instead of a Deception check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("fe4ec529-ff86-4da5-b426-ec6b5de63bb4"), "Trained in at least one type of one-handed firearm.");
            builder.HaveSpecificSkillProficiency(Guid.Parse("1d878f6a-6604-471d-8cae-d5db33852d42"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("6253cf2c-73cd-46c2-9eed-f1a74e231058"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eeeac58d-4afb-4d48-b2ac-50dc6dbf04f1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}