using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScrollTricksterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("91219035-8f94-412e-943e-db4e2ad71f33");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scroll Trickster Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the scroll trickster archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d8cfd11-33f7-426c-a350-15e68e4ab609"), Type = TextBlockType.Text, Text = "You’ve studied scrolls in depth. This might have been a comprehensive education in formal setting, or the sort of education where you somehow obtain a number of scrolls and try not to explode anything you didn’t mean to explode. You gain the (feat: Trick Magic Item) feat, and you gain a +2 circumstance bonus to skill checks to (feat: Trick | Trick Magic Item) scrolls. If you roll a critical failure to (feat: Trick a Magic Item | Trick Magic Item) that’s a scroll, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("9b6940ba-fe0f-4350-a4bd-ca9068fa5235"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("4e8545c1-e8d1-4769-9e76-0927119337ef"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("1b86ac7b-4830-4f75-8201-92920c86eadc"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("63db9349-bdcc-4575-8664-d28a2ef987e4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("57e8ab83-1afa-4f1a-b86f-37673e605650"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
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
                Id = Guid.Parse("a87b85d2-63c4-41ef-a6c4-4d2c7983b1f6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
