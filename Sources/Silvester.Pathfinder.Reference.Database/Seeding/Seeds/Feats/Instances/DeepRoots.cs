using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeepRoots : Template
    {
        public static readonly Guid ID = Guid.Parse("7c1f41b0-8193-4c67-bc52-d9d1631ea027");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deep Roots",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("483709d6-8401-42d7-9897-481e71c2e533"), Type = TextBlockType.Text, Text = "Your insidious mind-control spells send burrowing mental roots so deep that they tear at your target’s mind even after they are removed or have run their course. When you cast a spell that imposes the controlled condition or otherwise forces the target to take certain actions (such as (spell: command)), you can choose one target who critically failed its save. When that target finishes fulfilling any commands issued by your spell, or when the spell is dispelled or counteracted, it takes 1d4 mental damage per level of the spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42413cfd-afb9-49ad-a4bf-0afe6763174d"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
