using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HungryGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("685469c2-d925-4ca8-9c9c-37071b26b02f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hungry Goblin",
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
            yield return new TextBlock { Id = Guid.Parse("505edd68-e259-4ab0-abf5-a2d644408255"), Type = TextBlockType.Text, Text = "You’ll eat anything and anyone. Whenever you inflict persistent bleed damage with your jaws unarmed attack, you gain temporary Hit Points equal to half your level for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5f5a2763-5a7c-4d1c-8c49-20a6973cade0"), Feats.Instances.FangSharpener.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ee71b91-9287-44c2-a494-7e705639fbe4"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
