using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FakeOut : Template
    {
        public static readonly Guid ID = Guid.Parse("60fc1b0f-3a2f-40a2-bd98-9485c745b632");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fake Out",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally is about to use an action that requires an attack roll, targeting a creature within your weapon's first range increment.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4cc8542-f956-4722-ad2b-19f6509745f4"), Type = TextBlockType.Text, Text = "With a skilled flourish of your weapon, you force an enemy to acknowledge you as a threat. Make an attack roll to (action: Aid) the triggering attack. If you dealt damage to that enemy with the same weapon since the start of your last turn, you gain a +1 circumstance bonus to this roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4a55ec7-2ef0-4d3c-a5bb-e55558ac6cad"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
