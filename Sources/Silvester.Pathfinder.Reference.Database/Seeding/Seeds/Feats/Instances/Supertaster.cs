using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Supertaster : Template
    {
        public static readonly Guid ID = Guid.Parse("a5641715-4aed-4d20-b076-32fb7de65244");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Supertaster",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("65ec0a5b-9a82-4e69-b85d-5a871882caa0"), Type = TextBlockType.Text, Text = "You have refined your palate and have a discerning sense of taste that can detect abnormalities in the flavor and texture of food and beverages. When eating food or drinking a beverage, you automatically attempt to identify the ingredients, which might alert you to the presence of alterations or additives, such as poisons. The GM rolls a secret Perception check using the poison’s level to determine the DC; on a success, you learn that the food or drink was poisoned, but not the specific poison used." };
            yield return new TextBlock { Id = Guid.Parse("e3202a9c-d8a9-4ab3-b6a2-83cfef418bff"), Type = TextBlockType.Text, Text = "If you lick or taste something while Investigating or attempting to (action: Recall Knowledge) to identify something, if the taste would provide relevant additional information (at the GM’s discretion), you gain a +2 circumstance bonus to your check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d4f40825-f204-4893-bd77-a19131a869fe"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1b7b434-d1ac-4e3c-9dec-c449edc5bd9a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
