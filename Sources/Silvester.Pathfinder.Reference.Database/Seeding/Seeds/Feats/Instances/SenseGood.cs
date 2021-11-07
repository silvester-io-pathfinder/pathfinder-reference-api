using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SenseGood : Template
    {
        public static readonly Guid ID = Guid.Parse("26de299d-1289-4fb9-8d3c-847994dfb47b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sense Good",
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
            yield return new TextBlock { Id = Guid.Parse("fef6203f-a4c2-47a7-9367-1be754ece17b"), Type = TextBlockType.Text, Text = "The presence of goodness sickens you with its saccharine self-righteousness. When in the presence of an aura of good that is powerful or overwhelming, you detect the aura, though you might not do so instantly, and you can’t pinpoint the location. This acts as a vague sense, similar to humans’ sense of smell. A good creature using a disguise or otherwise trying to hide its presence attempts a Deception check against your Perception DC to hide its aura from you. If the creature succeeds at its Deception check, it is then temporarily immune to your Sense Good for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("ed404ff7-6cc8-46c3-a3fb-e561bc42d7a8"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("218c3576-b481-4168-bbf7-963d2e9c6041"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
