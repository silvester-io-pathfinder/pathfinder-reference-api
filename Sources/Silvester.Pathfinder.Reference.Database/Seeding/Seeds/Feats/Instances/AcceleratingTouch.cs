using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AcceleratingTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("0f4f4a69-cb09-4398-89ea-eb8001b5ae57");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Accelerating Touch",
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
            yield return new TextBlock { Id = Guid.Parse("8217bf47-8f2d-4bbb-acd2-d48b5af58a28"), Type = TextBlockType.Text, Text = "Your healing energies are infused with bounding energy. A creature that recovers Hit Points from your (spell: lay on hands) gains a +10-foot status bonus to its Speed until the end of its next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("e614a8e6-8361-42f9-883a-d73580d68f81"), Spells.Instances.LayOnHands.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13cd4479-f1dd-4f3c-ae39-d8475cdce940"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
