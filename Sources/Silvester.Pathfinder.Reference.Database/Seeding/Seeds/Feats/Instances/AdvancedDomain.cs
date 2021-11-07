using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedDomain : Template
    {
        public static readonly Guid ID = Guid.Parse("654e7820-88ec-47e7-8fe5-b9a766e654bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Domain",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times. Each time, you must select a different advanced domain spell from one of your domains.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47a40d0c-f89d-4670-9052-b9169c0a522b"), Type = TextBlockType.Text, Text = "Your studies or prayers have unlocked deeper secrets of your deity’s domain. You gain an advanced domain spell from one of your domains. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c1c444c3-a29f-45db-9176-c5ed5a319a54"), Feats.Instances.DomainInitiate.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e81df850-157e-448a-a1c0-30eaaf2d1bae"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
