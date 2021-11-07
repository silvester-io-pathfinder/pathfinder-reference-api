using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SoaringShape : Template
    {
        public static readonly Guid ID = Guid.Parse("fdbd5858-eeaf-4ed8-9ab6-b824fb2a8464");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soaring Shape",
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
            yield return new TextBlock { Id = Guid.Parse("9690b977-bf43-4a98-948f-4546c8004c60"), Type = TextBlockType.Text, Text = "Wings free you from the shackles of the ground below. Add the bat and bird forms in (spell: aerial form) to your wild shape list. If you have (feat: Insect Shape), you also add the wasp form to your wild shape list. If you have (feat: Ferocious Shape), you also add the pterosaur form to your wild shape list. Whenever you use (spell: wild shape) to gain a form that grants you a specific Acrobatics modifier, you gain a +1 status bonus to Acrobatics checks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("93413b80-7122-414c-9bdb-910c900e4dd2"), Feats.Instances.WildShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff86b3f3-c67f-47e1-8f64-6e6cba69cc33"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
