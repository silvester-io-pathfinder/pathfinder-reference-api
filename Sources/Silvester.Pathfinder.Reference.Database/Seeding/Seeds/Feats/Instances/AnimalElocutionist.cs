using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalElocutionist : Template
    {
        public static readonly Guid ID = Guid.Parse("407965bc-c46a-4aeb-900e-553df0d78e35");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Elocutionist",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ece04ed-f982-4f55-9806-3907b8446263"), Type = TextBlockType.Text, Text = "You hear animal sounds as conversations instead of unintelligent noise, and can respond in turn. You can speak to all animals, not just animals with a burrow Speed. You gain a +1 circumstance bonus to (action: Make an Impression) on animals (which usually uses the Diplomacy skill)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5292d5b7-0176-444e-9d52-40c382aeb893"), Feats.Instances.BurrowElocutionist.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("557ce720-ccbd-426f-ae32-7c342c8e9b82"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
