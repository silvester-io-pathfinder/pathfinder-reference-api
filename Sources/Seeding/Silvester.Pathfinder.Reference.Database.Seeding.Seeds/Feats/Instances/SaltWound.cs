using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SaltWound : Template
    {
        public static readonly Guid ID = Guid.Parse("ebee8776-415d-4a32-9a13-dba07d1a1989");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Salt Wound",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature that has blood and is not at its maximum Hit Points hits you with a melee Strike.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("265d003c-f2a4-433c-85b4-4fc1bcf8ab5e"), Type = TextBlockType.Text, Text = $"You channel salt and brine from your blood into the creature's wounds. The creature must attempt a Fortitude save using your class DC or spell DC, whichever is higher. On a failure, the creature takes 1d6 persistent acid damage and is sickened 1 by the pain. On a critical failure, it instead takes 2d6 persistent acid damage and is sickened 2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("320e5381-7b10-4588-8d58-c173b3368985"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
