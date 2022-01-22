using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FusedStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("78da6e9e-e2c8-4b7d-970e-aa481cdf2e3c");

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
            yield return new TextBlock { Id = Guid.Parse("073f55fe-1cf0-4b5a-8ee3-9b5820e15408"), Type = TextBlockType.Text, Text = $"When you prepare a staff, you can hold it up to a weapon to merge the two items. You can switch the fused item's form from the weapon to the staff or vice versa as a single action, which has the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait. When the item is in staff form, you can {ToMarkdownLink<Models.Entities.Rule>("Cast the Spells", Rules.Instances.CastASpell.ID)} from the staff and benefit from any other abilities the staff grants. The staff and the weapon share their fundamental runes, using whichever weapon potency and whichever striking rune is higher level. They don't share any other runes or specific abilities." };
            yield return new TextBlock { Id = Guid.Parse("320ae637-c1e3-4656-aa64-5ed24456ec4e"), Type = TextBlockType.Text, Text = $"You can {ToMarkdownLink<Models.Entities.Rule>("Cast Spells", Rules.Instances.CastASpell.ID)} from the staff as part of a {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} even when the staff is in weapon form. Otherwise, you can't cast the staff's spells while it's in weapon form." };
            yield return new TextBlock { Id = Guid.Parse("450ed356-9b69-4055-8fbe-a1eabdd55193"), Type = TextBlockType.Text, Text = $"The fusion lasts until your next daily preparations, though you can spend 10 minutes to separate the two items and meld the staff into a different weapon. The melding works for you alone. A different wielder can use the staff in its current form but can't transform it, get the benefit of the shared runes, or use its spells for a {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} if it's in weapon form." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6060dfb9-de96-45f4-98be-f2831327664e"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e26bb7f-9c64-498f-b8d2-09325689c3fa"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
