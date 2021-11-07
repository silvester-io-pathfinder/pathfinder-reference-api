using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InspireDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("f4258a47-6447-4a0b-8b70-a32f1d2001c1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inspire Defense",
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
            yield return new TextBlock { Id = Guid.Parse("9c848d52-6c77-4f7f-b12d-a4861dbcbe72"), Type = TextBlockType.Text, Text = "You learn the (spell: inspire defense) composition cantrip, which protects you and allies." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("f264e904-486b-4605-b63c-d7d9a196a13a"), Muses.Instances.Maestro.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f51e923c-18f6-436b-a9a4-47e76f596834"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
