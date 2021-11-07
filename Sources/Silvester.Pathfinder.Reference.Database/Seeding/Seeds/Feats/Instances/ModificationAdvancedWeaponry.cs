using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationAdvancedWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("d492b2e9-66ab-4e68-8423-e65125529d3b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Advanced Weaponry",
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
            yield return new TextBlock { Id = Guid.Parse("c54e4cfe-d82d-45ad-b80d-21cac3ee68d5"), Type = TextBlockType.Text, Text = "You’ve powered up your construct’s weaponry. Choose one of your construct’s unarmed attacks to gain your choice of one initial weapon modification, chosen from the list on G&amp;G pg. 18 or from other initial weapon modifications to which you have access. The unarmed attack must meet any requirements for the chosen traits (such as being a melee attack for (feat: entangling form | Modification - Entangling Form)), and since it’s an unarmed attack, it can never meet certain requirements, such as being a simple weapon for (feat: complex simplicity | Modification - Complex Simplicity)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b8e336e-d069-407a-8fae-c355487f6c75"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
