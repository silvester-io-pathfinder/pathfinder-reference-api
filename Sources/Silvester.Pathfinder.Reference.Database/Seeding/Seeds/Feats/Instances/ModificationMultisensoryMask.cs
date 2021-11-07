using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMultisensoryMask : Template
    {
        public static readonly Guid ID = Guid.Parse("48794a71-6fc5-4755-b3bd-e918d79b662c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Multisensory Mask",
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
            yield return new TextBlock { Id = Guid.Parse("a67fc96e-d92e-46af-a48d-6d85cf5240cd"), Type = TextBlockType.Enumeration, Text = "*Subterfuge Suit Only**" };
            yield return new TextBlock { Id = Guid.Parse("41c76852-3364-464c-934f-90c30e4aefeb"), Type = TextBlockType.Text, Text = "You’ve built a multisensory mask over your armor that protects you by distorting your figure from all senses, leaving behind only a hazy image, muffled sounds, and so forth. While wearing the armor, you gain concealment against all creatures, even if they are using a nonvisual precise sense, such as a bat’s echolocation. As normal for effects that leave your location obvious, you can’t use this concealment to (action: Hide) or (action: Sneak). If you use a hostile action, the concealment ends until you restore the mask as a single action, which has the (trait: manipulate) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0694385-a6b8-415b-a36e-8e0c1067dab9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
