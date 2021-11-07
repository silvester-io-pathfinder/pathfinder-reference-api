using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonShape : Template
    {
        public static readonly Guid ID = Guid.Parse("e9510e7f-8814-4439-a33c-5d0ed5f72b4b");

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
            yield return new TextBlock { Id = Guid.Parse("44bfbb4e-631d-41f4-9fd2-bc413def76fe"), Type = TextBlockType.Text, Text = "You can take on the form of some of the world’s most fearsome creatures. Add the forms listed in (Spell: dragon form) to your (Spell: wild shape) list. Whenever you’re polymorphed into another form using (Spell: wild shape), you gain resistance 5 to your choice of acid, cold, electricity, fire, or poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("649464d0-26ca-4375-a2f3-31e60ac51dbd"), Feats.Instances.SoaringShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ded6fae-87c3-4fe6-9d94-cac9140536ce"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
