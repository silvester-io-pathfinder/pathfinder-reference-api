using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Streetwise : Template
    {
        public static readonly Guid ID = Guid.Parse("62318efd-fe96-4a67-ae6a-0c7ed986dfda");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Streetwise",
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
            yield return new TextBlock { Id = Guid.Parse("d79791bc-4699-4d89-8491-a7030ac92daf"), Type = TextBlockType.Text, Text = "You know about life on the streets and feel the pulse of your local settlement. You can use your Society modifier instead of your Diplomacy modifier to (Action: Gather Information). In any settlement you frequent regularly, you can use the (Action: Recall Knowledge) action with Society to know the same sorts of information that you could discover with Diplomacy to (Action: Gather Information). The DC is usually significantly higher, but you know the information without spending time gathering it. If you fail to recall the information, you can still subsequently attempt to (Action: Gather Information) normally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("79efb522-04e5-4036-8abf-8ad0909862c8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("10e4f4ee-d6fb-4881-8758-66701d362d06"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
