using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LitanyAgainstSloth : Template
    {
        public static readonly Guid ID = Guid.Parse("8f19adb6-af1c-48f7-858d-f241852e9394");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Litany Against Sloth",
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
            yield return new TextBlock { Id = Guid.Parse("4599e824-2630-470e-9898-876af2e9b68f"), Type = TextBlockType.Text, Text = "You rail against the sin of sloth, turning a foe’s laziness against it. You can cast the (spell: litany against sloth) devotion spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("d04af1a6-b92d-406d-a164-c9237769855c"), Classes.Instances.Champion.ID);
            builder.HaveSpecificTenet(Guid.Parse("e9022e6c-646b-49ad-9564-e77ee7aaa4da"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08f53a9e-0851-4e95-a34b-6b7bdffd1690"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
