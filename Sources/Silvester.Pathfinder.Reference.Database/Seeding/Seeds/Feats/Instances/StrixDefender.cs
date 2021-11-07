using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrixDefender : Template
    {
        public static readonly Guid ID = Guid.Parse("963d2f6c-2196-4232-b991-7d35157d1a41");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strix Defender",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b074a45-5610-4ad9-8b31-139782d59819"), Type = TextBlockType.Text, Text = "Your ancestral feud with humans gives you experience dealing with vicious foes, and your vengeance knows no bounds. You gain a +1 circumstance bonus to Intimidation, Perception, and Survival checks against humans, as well as on damage rolls against humans with weapons and unarmed attacks. However, your hatred of humans is immediately obvious, giving you a -2 circumstance penalty to Diplomacy checks against them and usually starting their attitude one step worse towards you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b289fa9e-b510-499c-a3ff-e4e028121ddb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
