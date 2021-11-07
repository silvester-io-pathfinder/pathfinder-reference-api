using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VengefulOath : Template
    {
        public static readonly Guid ID = Guid.Parse("8d26243b-b32f-4996-9c83-fb41392b9da7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vengeful Oath",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("abba5e23-9306-4960-8177-9f12cb2d9cef"), Type = TextBlockType.Text, Text = "You’ve sworn an oath to hunt down wicked evildoers and bring them to judgment. Add the following tenet to your code after the others:" };
            yield return new TextBlock { Id = Guid.Parse("91d7e119-3c8a-4f4e-a303-58d8089fb040"), Type = TextBlockType.Enumeration, Text = " : You must hunt down and exterminate evil creatures that have committed heinous atrocities as long as you have a reasonable chance of success and aren’t engaged in a mission that would prevent your doing so." };
            yield return new TextBlock { Id = Guid.Parse("98e6b45f-917f-4009-96a2-21d0e6ff8285"), Type = TextBlockType.Text, Text = "You can use (spell: lay on hands) to damage a creature you witness harming an innocent or a good ally as if it were undead; in this case, (spell: lay on hands) deals good damage instead of positive damage and gains the (trait: good) trait. This good damage can affect non-evil creatures. This doesn’t prevent you from healing such a creature with (spell: lay on hands); you choose whether to heal or harm." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("aadf80ff-514e-4ce2-93c5-c51938dcdac5"), Causes.Instances.Paladin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c970ba41-7d74-4dee-942a-bfbd5b9e55fd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
