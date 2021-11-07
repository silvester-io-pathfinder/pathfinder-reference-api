using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertLongevity : Template
    {
        public static readonly Guid ID = Guid.Parse("6807980c-12e7-4e26-85da-33e27ab72954");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Longevity",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47dd9b9a-59f4-44a5-a1c3-1fda6d4053b2"), Type = TextBlockType.Text, Text = "You’ve continued to refine the knowledge and skills you’ve gained through your life. When you choose a skill in which to become trained with (Feat: Ancestral Longevity), you can also choose a skill in which you are already trained and become an expert in that skill. This lasts until your (Feat: Ancestral Longevity) expires." };
            yield return new TextBlock { Id = Guid.Parse("0aba42ae-8649-4621-9cfc-57549a659fe1"), Type = TextBlockType.Text, Text = "When the effects of (Feat: Ancestral Longevity) and Expert Longevity expire, you can retrain one of your skill increases. The skill increase you gain from this retraining must either make you trained in the skill you chose with (Feat: Ancestral Longevity) or make you an expert in the skill you chose with Expert Longevity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d1979af3-91f3-4cd3-8967-7ed4d62c3be2"), Feats.Instances.AncestralLongevity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ebe864e-5746-4467-8e9c-37202f25d8f5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
