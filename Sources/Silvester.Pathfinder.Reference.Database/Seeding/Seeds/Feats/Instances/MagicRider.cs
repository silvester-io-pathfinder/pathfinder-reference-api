using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicRider : Template
    {
        public static readonly Guid ID = Guid.Parse("7922ec0b-9292-4087-a79f-e2eff71c19b4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magic Rider",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6393ba83-b39a-4ce8-8897-2e5ea0e931d1"), Type = TextBlockType.Text, Text = "Your people used powerful magic to travel between distant worlds, and the remnants of that magic make such transportation easier for you. When you are the target of a (trait: teleportation) spell that transports more than one person, it can affect an additional person beyond the normal limit, chosen by the caster. Additionally, when you’re the target of a (spell: teleport) spell, you and the other targets arrive no farther than 1 mile off target, regardless of distance traveled." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6cb81c1-b883-4929-a731-32a627434055"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
