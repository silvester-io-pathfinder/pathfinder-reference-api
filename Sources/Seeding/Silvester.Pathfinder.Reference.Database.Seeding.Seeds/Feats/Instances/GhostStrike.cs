using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GhostStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("e4de45d5-5cea-4d29-be8a-790d0122771d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ghost Strike",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b16b7fe6-1603-496d-be54-09742bbe5faa"), Type = TextBlockType.Text, Text = $"Once per day, you can infuse a weapon you are carrying with magical energies that allow it to strike true against incorporeal undead. The weapon gains the effects of the {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("ghost touch", Items.WeaponPropertyRunes.Instances.GhostTouch.ID)} property rune for 10 minutes." };
            yield return new TextBlock { Id = Guid.Parse("b4541691-8984-4344-a37b-f62131dc70b9"), Type = TextBlockType.Text, Text = $"At 10th level, you can apply this effect to two weapons instead of one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("14619525-3599-4187-9c51-4246aa72e228"), Feats.Instances.GhostHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd255aaa-4af8-4e43-a6f0-e7f87dbdfb7e"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
