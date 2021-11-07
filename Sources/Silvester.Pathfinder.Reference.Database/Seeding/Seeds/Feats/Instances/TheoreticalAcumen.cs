using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TheoreticalAcumen : Template
    {
        public static readonly Guid ID = Guid.Parse("cf7a8986-702b-4fd5-9369-b17cbaefd53f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Theoretical Acumen",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You succeed at a skill check to Recall Knowledge to identify a creature.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b86a459f-267a-4058-974d-3d921256f80b"), Type = TextBlockType.Text, Text = "You study a creature’s form and behavior to hypothesize likely means of overcoming its strengths. Once before the end of your next turn, you can use the skill modifier from the triggering check in place of your saving throw modifier against one of the creature’s abilities, in place of your Perception modifier to (action: Seek) the creature, in place of your Deception modifier to (action: Feint) against the creature, or in place of your Intimidation modifier to (action: Demoralize) the creature. Alternatively, against one of the creature’s attacks, you can use your DC for the skill used in the triggering check in place of your AC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9c09a9e-c76a-4623-a79a-83e0b343844f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
