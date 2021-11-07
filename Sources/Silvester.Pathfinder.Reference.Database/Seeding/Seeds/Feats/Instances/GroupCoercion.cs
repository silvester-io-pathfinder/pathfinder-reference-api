using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GroupCoercion : Template
    {
        public static readonly Guid ID = Guid.Parse("4d0b9e08-03e8-4d6d-b151-ad1417241f07");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Group Coercion",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3bca6be3-6637-4059-a6f6-7b4b3cea53d8"), Type = TextBlockType.Text, Text = "When you (action: Coerce), you can compare your Intimidation check result to the Will DCs of two targets instead of one. It’s possible to get a different degree of success for each target. The number of targets you can (action: Coerce) in a single action increases to four if you’re an expert, 10 if you’re a master, and 25 if you’re legendary." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("dad73679-63b8-4c1c-a92f-4869ca64ae97"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("067c2055-1a48-443c-b708-63a10d2b54b1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
