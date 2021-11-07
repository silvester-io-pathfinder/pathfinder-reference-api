using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SuperiorSight : Template
    {
        public static readonly Guid ID = Guid.Parse("5e42e93f-c94c-4c7b-95f4-100376fa6a60");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Superior Sight",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("90d51db5-5936-4828-bcfa-5e7a81100321"), Type = TextBlockType.Text, Text = "~ Access: secure Visitor’s Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("5e2b0d4b-78a7-40c7-a945-507e74260ae7"), Type = TextBlockType.Text, Text = "Your senses are peerless. You gain a +2 circumstance bonus to Perception checks, and you gain low-light vision. If you already have low-light vision, gain darkvision instead. Furthermore, when you target an enemy, you automatically succeed at the flat check if that enemy is concealed, hidden, or undetected." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e583eba9-f164-4875-bb60-068ae2a7cc47"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
