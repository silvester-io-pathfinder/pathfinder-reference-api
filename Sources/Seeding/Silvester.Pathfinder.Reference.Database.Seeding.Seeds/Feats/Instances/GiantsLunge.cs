using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GiantsLunge : Template
    {
        public static readonly Guid ID = Guid.Parse("5b7106e8-6a7a-4e46-bec6-1dd7e4443218");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Giant's Lunge",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("03e25f0b-3388-4acf-971d-a14221f599b0"), Type = TextBlockType.Text, Text = "You extend your body and prepare to attack foes outside your normal reach. Until your rage ends, all your melee weapons and unarmed attacks gain (trait: reach 10). This doesn't increase the reach of any weapon or unarmed attack that already has the (trait: reach) trait, but it does combine with abilities that increase your reach due to increased size, such as (feat: Giant's Stature)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("38cd2ac6-6bc1-4dd3-8d0a-30b1364d4bf5"), Instincts.Instances.GiantInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d32fd21-1953-4337-89bd-d87695a715cb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
