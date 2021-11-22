using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AssuredKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("ecb7339e-27db-4a51-bc70-39b7ebdcc3da");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assured Knowledge",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a8c202c-c619-45dd-96d4-34d8c59004eb"), Type = TextBlockType.Text, Text = "You can procure information with confidence. Whenever you (action: Recall Knowledge) using any skill (including Loremaster Lore), you can forgo rolling your check to instead receive a result of 10 + your proficiency bonus (don't apply any other bonuses, penalties, or modifiers). As long as you are an expert in a skill, you meet the prerequisites for the (feat: Automatic Knowledge) skill feat in that skill, even if you don't have (feat: Assurance) in that skill." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7bd16a83-8896-4edb-8ae2-afdcb1f96083"), Feats.Instances.LoremasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb506118-4834-4f07-8749-ede81b2e3638"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
