using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConsultTheStars : Template
    {
        public static readonly Guid ID = Guid.Parse("913370e4-40cd-4d38-8238-d9a4e741391a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Consult the Stars",
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
            yield return new TextBlock { Id = Guid.Parse("b11313e4-21ea-4922-a092-6d54778e4435"), Type = TextBlockType.Text, Text = "You find wisdom in the movements of the heavens. Once per day, you can spend 10 minutes to draw upon your readings of a recent night's sky to gain the trained proficiency rank in one skill of your choice; the chosen skill's key attribute must be Charisma, Intelligence, or Wisdom. This proficiency lasts until your next daily preparation. Since this proficiency is temporary, you can't use it as a prerequisite for a skill increase or a permanent character option like a feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0032b62-6646-4c3e-aaa0-437c17e83dd4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
