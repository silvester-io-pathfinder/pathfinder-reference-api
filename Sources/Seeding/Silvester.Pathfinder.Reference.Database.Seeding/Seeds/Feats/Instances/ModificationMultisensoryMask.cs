using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMultisensoryMask : Template
    {
        public static readonly Guid ID = Guid.Parse("eed55d09-c432-4613-b82a-118f501e50f3");

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
            yield return new TextBlock { Id = Guid.Parse("4925c719-7ef3-4559-b4e8-48fb0bf62658"), Type = TextBlockType.Enumeration, Text = "*Subterfuge Suit Only**" };
            yield return new TextBlock { Id = Guid.Parse("e4f4ac85-07c1-42bc-b45d-a024164cb202"), Type = TextBlockType.Text, Text = "You've built a multisensory mask over your armor that protects you by distorting your figure from all senses, leaving behind only a hazy image, muffled sounds, and so forth. While wearing the armor, you gain concealment against all creatures, even if they are using a nonvisual precise sense, such as a bat's echolocation. As normal for effects that leave your location obvious, you can't use this concealment to (action: Hide) or (action: Sneak). If you use a hostile action, the concealment ends until you restore the mask as a single action, which has the (trait: manipulate) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("955b06bf-8046-4058-bd15-eb1f155777aa"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
