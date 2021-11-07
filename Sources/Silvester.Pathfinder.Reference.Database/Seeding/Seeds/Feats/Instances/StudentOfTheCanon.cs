using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StudentOfTheCanon : Template
    {
        public static readonly Guid ID = Guid.Parse("d7460317-a774-42a4-833f-2fc9fd10e788");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Student of the Canon",
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
            yield return new TextBlock { Id = Guid.Parse("8dbb5156-6310-4cbe-88ac-f4d7b9cc81c4"), Type = TextBlockType.Text, Text = "You’ve researched many faiths enough to recognize notions about them that are unlikely to be true. If you roll a critical failure at a Religion check to (Action: Decipher Writing) of a religious nature or to (Action: Recall Knowledge) about the tenets of faiths, you get a failure instead. When attempting to (Action: Recall Knowledge) about the tenets of your own faith, if you roll a failure, you get a success instead, and if you roll a success, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d9cb08e3-8b7f-4add-8205-aca7c89bf42f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9ba9887-44a7-42a6-9299-19e17a38c66c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
