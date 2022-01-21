using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KreightonsCognitiveCrossover : Template
    {
        public static readonly Guid ID = Guid.Parse("d6643dde-ae83-4d94-a8d5-0134549530b7");

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
            yield return new TextBlock { Id = Guid.Parse("16ab30be-7382-4839-915a-dccf069a4d0e"), Type = TextBlockType.Text, Text = "~ Access: Member of the Pathfinder Society." };
            yield return new TextBlock { Id = Guid.Parse("1e47d992-6c6b-4574-8967-c711fb823645"), Type = TextBlockType.Text, Text = "Kreighton teaches his students that an agile mind can glean clues leading to the truth, even from the most unlikely of sources. You immediately reattempt the triggering check using the other chosen skill." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb549153-687a-4861-bdcc-5584506c618d"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
