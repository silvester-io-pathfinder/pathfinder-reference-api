using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OtherworldlyAcumen : Template
    {
        public static readonly Guid ID = Guid.Parse("342b6895-27c3-46ad-bce8-321120a452cc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Otherworldly Acumen",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e7f4f2c-5025-4011-be54-d07c00d915ef"), Type = TextBlockType.Text, Text = $"The arcane magic you possess grows in power and complexity. Choose one common 2nd-level spell from the same tradition as an innate spell you previously gained from another elf ancestry feat (from the arcane list if you have {ToMarkdownLink<Models.Entities.Feat>("Otherworldly Magic", Feats.Instances.OtherworldlyMagic.ID)}, for example). You can cast that spell as an innate spell once per day, using the same tradition as the list you chose the spell from." };
            yield return new TextBlock { Id = Guid.Parse("d610591d-6bb7-4c57-9ab2-e47f9ebc0e2d"), Type = TextBlockType.Text, Text = $"Your magic is adaptable. By spending 1 day of downtime, you can change the spell you chose to a different common 2nd-level spell from the same tradition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("ffa71810-7894-4653-858b-e4c990dd6551"), "At least one innate spell gained from an elf ancestry feat.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1ac8eff-a782-434c-adbb-51867ff342a4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
