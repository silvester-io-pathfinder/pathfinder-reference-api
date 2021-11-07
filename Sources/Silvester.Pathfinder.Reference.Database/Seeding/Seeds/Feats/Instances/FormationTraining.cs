using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormationTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("69fedf0d-2619-4538-9d6c-df6b75d338af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Formation Training",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7bb9038-eab4-4000-a0e5-52dadc4d3b30"), Type = TextBlockType.Text, Text = "You know how to fight in formation with your brethren. When you are adjacent to at least two hobgoblin allies, you gain a +1 circumstance bonus to AC and saving throws. This bonus increases to +2 on Reflex saves against area effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("ceb87fe9-207d-4d14-b5e2-d5d34536c765"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a57de82-6c62-45f3-84c9-8f56ace87c7d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
