using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InspireHeroics : Template
    {
        public static readonly Guid ID = Guid.Parse("f9fa0a9b-0dc5-4990-b55e-d67660966e0d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inspire Heroics",
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
            yield return new TextBlock { Id = Guid.Parse("e0090616-a505-4552-a037-00abeedc338c"), Type = TextBlockType.Text, Text = "Your performances inspire even greater deeds in your allies. You learn the (spell: inspire heroics) metamagic focus spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("c518bb7b-4f96-4cbb-9ab5-005c248de23f"), Muses.Instances.Maestro.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fce16205-4fa7-4fd6-b458-898aa50f4e0a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
