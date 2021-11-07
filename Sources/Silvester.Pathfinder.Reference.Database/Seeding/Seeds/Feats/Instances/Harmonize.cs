using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Harmonize : Template
    {
        public static readonly Guid ID = Guid.Parse("efc1d638-a6c6-4a0c-9852-e2fb2efef987");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Harmonize",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93996805-0c34-48fc-ae38-501867fef998"), Type = TextBlockType.Text, Text = "You can perform multiple compositions simultaneously. If your next action is to cast a composition, it becomes a harmonized composition. Unlike a normal composition, a harmonized composition doesn’t end if you cast another composition, and you can cast another composition on the same turn as a harmonized one. Casting another harmonized composition ends any harmonized composition you have in effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("dcf0aecd-c649-4528-adcb-36abb01e8008"), Muses.Instances.Maestro.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("935743c5-754b-44ec-bc79-090478b5c4e5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
