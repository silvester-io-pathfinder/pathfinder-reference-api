using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KreightonsCognitiveCrossover : Template
    {
        public static readonly Guid ID = Guid.Parse("e8e6b2bd-ed02-4a97-ac3a-abd120b24569");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kreighton's Cognitive Crossover",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "When you gain this feat, choose two of the following skills: Arcana, Crafting, Lore (any one), Medicine, Nature, Occultism, Religion, or Society.",
                Trigger = "You gain no information from a Recall Knowledge check (usually because you failed the secret check) using one of the two skills you chose for this feat.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1033aef7-c716-43ba-a2ff-d044df53b519"), Type = TextBlockType.Text, Text = "~ Access: Member of the Pathfinder Society." };
            yield return new TextBlock { Id = Guid.Parse("065af077-abcc-4077-bf54-fd131616e3f0"), Type = TextBlockType.Text, Text = "Kreighton teaches his students that an agile mind can glean clues leading to the truth, even from the most unlikely of sources. You immediately reattempt the triggering check using the other chosen skill." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00da2ce1-b088-4f56-a1b5-5c6d24ea5340"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
