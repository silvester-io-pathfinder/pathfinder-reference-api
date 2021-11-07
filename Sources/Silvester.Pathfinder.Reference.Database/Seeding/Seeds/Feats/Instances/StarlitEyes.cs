using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StarlitEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("f7867cf6-47ee-4c46-b1db-880933c4cf5c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Starlit Eyes",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("58aad64e-a92c-4898-8bc1-bf680a64ffb4"), Type = TextBlockType.Text, Text = "Starlight shines in your sight, enhancing your perception and range. When you make a ranged (action: Strike) while in (feat: Arcane Cascade) stance, you lower the DC of your flat check to target a creature that’s concealed or hidden from you. The DC is reduced to 3 instead of 5 against a concealed creature and to 9 instead of 11 against a hidden one. When you cast (spell: shooting star) and target a hidden creature, you don’t have to attempt the flat check for targeting a hidden creature with a ranged (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("57096455-0076-4acc-b2ce-6f0223f85e0e"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("8d38e783-4b16-4655-8bb2-03eadff6d02d"), HybridStudies.Instances.StarlitSpan.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eafe98cc-1860-4459-9704-a0d7f2c6e894"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
