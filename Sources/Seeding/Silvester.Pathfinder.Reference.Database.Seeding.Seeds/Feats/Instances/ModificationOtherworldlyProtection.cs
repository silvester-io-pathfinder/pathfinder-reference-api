using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationOtherworldlyProtection : Template
    {
        public static readonly Guid ID = Guid.Parse("7586617c-2b9c-4b11-9da4-9204d02fb678");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Otherworldly Protection",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed8af4e2-1ec5-4223-b884-333de9e048b9"), Type = TextBlockType.Text, Text = "Just because you use science doesn't mean you can't build your armor with carefully chosen materials and gizmos designed to protect against otherworldly attacks. You gain resistance equal to 3 + half your level to negative damage, or to positive damage if you have negative healing (such as if you're a dhampir). You gain the same amount of resistance to any types of alignment damage—good, evil, chaotic, lawful—that can damage you (note that creatures don't take a given type of alignment damage unless they are of the opposing alignment; for instance, you can take evil damage only if you are good in alignment)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f23aa55c-5b67-4f9d-8938-c1072b24a3ff"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
