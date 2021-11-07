using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WatchfulHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("ffdadd60-2bea-469e-af92-a9c5761d4392");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Watchful Halfling",
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
            yield return new TextBlock { Id = Guid.Parse("aaf03489-fe72-48b9-9a43-6f5995f31b1e"), Type = TextBlockType.Text, Text = "Your communal lifestyle causes you to pay close attention to the people around you, allowing you to more easily notice when they act out of character. You gain a +2 circumstance bonus to Perception checks when using the (Action: Sense Motive) basic action to notice enchanted or possessed characters. If you aren’t actively using (Action: Sense Motive) on an enchanted or possessed character, the GM rolls a secret check, without the usual circumstance and with a –2 circumstance penalty, for you to potentially notice the enchantment or possession anyway." };
            yield return new TextBlock { Id = Guid.Parse("c6e5fa1a-3722-4047-9e98-b0931a469934"), Type = TextBlockType.Text, Text = "In addition to using it for skill checks, you can use the (Action: Aid) basic action to grant a bonus to another creature’s saving throw or other check to overcome enchantment or possession. As usual for (Action: Aid), you need to prepare by using an action on your turn to encourage the creature to fight against the effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("373d46cd-64cb-4c93-b7e5-c1eecc5697ba"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
