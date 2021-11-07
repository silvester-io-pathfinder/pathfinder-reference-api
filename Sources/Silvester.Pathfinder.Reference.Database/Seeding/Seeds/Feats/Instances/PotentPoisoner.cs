using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PotentPoisoner : Template
    {
        public static readonly Guid ID = Guid.Parse("477f34e2-e401-4614-9fa7-a84bfaf5b246");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Potent Poisoner",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47b88f6a-4d62-4045-b4b4-9a0b2e300d9c"), Type = TextBlockType.Text, Text = "By concentrating your poisons’ toxic components, you make them harder for victims to resist. When you craft an alchemical item with the (trait: poison) trait by any means, the DC is increased by up to 4, to a maximum of your class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("098de0b2-dbef-4747-b8d2-959da30f189f"), Feats.Instances.PowerfulAlchecmy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b6ef8e6a-c3ac-46e1-9b9b-98a0f53f5374"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
