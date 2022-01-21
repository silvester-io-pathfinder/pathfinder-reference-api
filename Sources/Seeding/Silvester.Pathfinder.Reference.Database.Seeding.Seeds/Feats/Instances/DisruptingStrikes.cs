using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisruptingStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("1d77be17-355c-4f71-b65c-e5266c068948");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disrupting Strikes",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7fe11efc-379b-47af-b0d0-2a6f625f30cc"), Type = TextBlockType.Text, Text = $"You call forth positive energy from within to help you destroy undead. Your weapon and unarmed {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} gain the effects of a {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("disrupting property rune", Items.WeaponPropertyRunes.Instances.Disrupting.ID)} until the start of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("f890775a-835f-4eec-95df-38d368854cdb"), Type = TextBlockType.Text, Text = $"If you're 14th level or higher, your {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} instead gain the effects of a greater {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("disrupting property rune", Items.WeaponPropertyRunes.Instances.Disrupting.ID)}. The DC for the rune's effect is equal to your class DC or spell DC, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cfe1c69-996b-45d3-b112-ec9d4a81e206"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
