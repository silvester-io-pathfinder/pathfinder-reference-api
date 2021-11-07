using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VikingDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("c379cefe-f738-481a-a834-e2f308572ef1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Viking Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the viking archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00c50a0c-f013-40a1-b168-50de9ec027ca"), Type = TextBlockType.Text, Text = "Vikings spend long periods of time at sea, only to leap from their boats at a moment’s notice, charge through the surf, and take their enemies by storm. You’re trained in Sailing Lore. When moving through water using your land Speed, you ignore difficult terrain resulting from shallow water, such as in bogs or on beaches. In addition, if you roll a success for your Athletics check to (action: Swim), you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("86e846bb-18cc-4935-abda-6cdaa6e80786"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cd10363-5df1-43b8-a459-2d76a98a1b6e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
