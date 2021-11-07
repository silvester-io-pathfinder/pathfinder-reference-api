using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MesmerizingGaze : Template
    {
        public static readonly Guid ID = Guid.Parse("e2765d84-bf76-4c78-9009-9ac92bfb8f16");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mesmerizing Gaze",
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
            yield return new TextBlock { Id = Guid.Parse("d40cb0af-18ad-456c-bae9-33e4bec0191b"), Type = TextBlockType.Text, Text = "Eye contact can help you invade another creature’s thoughts, as though you were peering directly through their eyes and into their mind. When you cast an (trait: enchantment) spell that targets only one creature within 30 feet who can see you, you can gaze into the creature’s eyes, causing the creature to take a –1 status penalty to their saving throw against your spell unless they choose to break the eye contact as a reaction. If they don’t look away, you’re fascinated with them until the end of your next turn as you maintain the eye contact. When you use Mesmerizing Gaze, the (action: Avert Gaze) action provides its bonus to saving throws against your spell, as the spell’s effects have become connected to the eye contact." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4059465d-5da0-4f04-8fb8-584847093bc2"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
