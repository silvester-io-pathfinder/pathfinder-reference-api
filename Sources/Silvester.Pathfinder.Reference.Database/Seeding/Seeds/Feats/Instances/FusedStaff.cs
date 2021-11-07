using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FusedStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("13c392c3-2c8f-4e05-815a-de832f60be3b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fused Staff",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09cd2bbe-c499-428e-80e7-ffd2043ac314"), Type = TextBlockType.Text, Text = "When you prepare a staff, you can hold it up to a weapon to merge the two items. You can switch the fused item’s form from the weapon to the staff or vice versa as a single action, which has the (trait: concentrate) trait. When the item is in staff form, you can (action: Cast the Spells | Cast a Spell) from the staff and benefit from any other abilities the staff grants. The staff and the weapon share their fundamental runes, using whichever weapon potency and whichever striking rune is higher level. They don’t share any other runes or specific abilities." };
            yield return new TextBlock { Id = Guid.Parse("917667f0-371a-4e64-a3ba-85ce94cbec56"), Type = TextBlockType.Text, Text = "You can (action: Cast Spells | Cast a Spell) from the staff as part of a (feat: Spellstrike) even when the staff is in weapon form. Otherwise, you can’t cast the staff’s spells while it’s in weapon form." };
            yield return new TextBlock { Id = Guid.Parse("85d4e020-049d-4087-8395-6dfda54321b1"), Type = TextBlockType.Text, Text = "The fusion lasts until your next daily preparations, though you can spend 10 minutes to separate the two items and meld the staff into a different weapon. The melding works for you alone. A different wielder can use the staff in its current form but can’t transform it, get the benefit of the shared runes, or use its spells for a (feat: Spellstrike) if it’s in weapon form." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("38f44add-f663-4e29-bd8f-b15c41dda461"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35ec9119-d865-45fe-9a4d-c3d6e3fe373d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
