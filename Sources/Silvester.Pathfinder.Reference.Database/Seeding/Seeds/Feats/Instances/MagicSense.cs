using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicSense : Template
    {
        public static readonly Guid ID = Guid.Parse("36c64f15-cad2-4349-bb3d-0c2292e04edf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magic Sense",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9cdbf8e8-1022-4f6a-82a9-c105f5d83275"), Type = TextBlockType.Text, Text = "You have a literal sixth sense for ambient magic in your vicinity. You can sense the presence of magic auras as though you were always using a 1st-level (spell: detect magic) spell. This detects magic in your field of vision only. When you (action: Seek), you gain the benefits of a 3rd-level (spell: detect magic) spell on things you see (in addition to the normal benefits of (action: Seeking | Seek)). You can turn this sense off and on with a free action at the start or the end of your turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63bdd119-9483-4656-8766-85f426361cdb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
