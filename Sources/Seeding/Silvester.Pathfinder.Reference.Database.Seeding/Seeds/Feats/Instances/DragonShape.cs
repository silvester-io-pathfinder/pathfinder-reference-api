using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonShape : Template
    {
        public static readonly Guid ID = Guid.Parse("68b6d5d5-85ba-45ab-a009-ff3a6cb532e6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Shape",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d948db60-d781-49ea-a2f9-12c3df01ab9c"), Type = TextBlockType.Text, Text = "You can take on the form of some of the world's most fearsome creatures. Add the forms listed in (Spell: dragon form) to your (Spell: wild shape) list. Whenever you're polymorphed into another form using (Spell: wild shape), you gain resistance 5 to your choice of acid, cold, electricity, fire, or poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a26af053-06bf-4ab3-a541-997538694d7a"), Feats.Instances.SoaringShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b32b0c91-2c1a-44b2-b6bf-4443fdc4cf6c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
