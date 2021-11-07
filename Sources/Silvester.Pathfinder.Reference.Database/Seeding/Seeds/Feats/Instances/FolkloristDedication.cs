using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FolkloristDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("5b9c2734-1039-449a-811c-9bf598297c61");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Folklorist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the folklorist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fda0e6a-2831-4375-876e-3501cf81380a"), Type = TextBlockType.Text, Text = "You are a master archivist and entertainer, capable of pulling wisdom from the tales you tell and weaving your allies and enemies into a powerful narrative. You gain the (feat: Spin Tale) action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e83e5b63-df32-49c9-99b7-7fe1c1edabe2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("740c89ad-5751-4ec0-a507-b51d48c73276"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
