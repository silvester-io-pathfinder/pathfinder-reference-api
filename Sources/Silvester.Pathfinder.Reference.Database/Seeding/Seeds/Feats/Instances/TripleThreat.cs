using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TripleThreat : Template
    {
        public static readonly Guid ID = Guid.Parse("ba378fd5-d672-45b8-aab5-b79134325c1e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Triple Threat",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c30606c2-b831-420e-af55-7ae990bf43a3"), Type = TextBlockType.Text, Text = "You can divide your attention three ways when hunting. When you use (feat: Hunt Prey), you can designate three creatures as prey, designate two creatures as prey and share the effect with one ally (as (feat: Shared Prey)), or designate one creature as prey and share the effect with two allies." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7fb14bfa-6684-4605-9cb2-5850df955a6e"), Feats.Instances.SharedPrey.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("758adaa8-987f-4ff1-af8d-bcebb5fe3318"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
