using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OtherworldlyAcumen : Template
    {
        public static readonly Guid ID = Guid.Parse("620eb6f8-deaa-4e1d-ab8b-f30328d8636b");

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
            yield return new TextBlock { Id = Guid.Parse("2564b463-5d78-4964-a6a4-d50ac7862f0b"), Type = TextBlockType.Text, Text = "The arcane magic you possess grows in power and complexity. Choose one common 2nd-level spell from the same tradition as an innate spell you previously gained from another elf ancestry feat (from the arcane list if you have (feat: Otherworldly Magic), for example). You can cast that spell as an innate spell once per day, using the same tradition as the list you chose the spell from." };
            yield return new TextBlock { Id = Guid.Parse("dbf22805-23cd-4c06-9f2f-458314a4f2aa"), Type = TextBlockType.Text, Text = "Your magic is adaptable. By spending 1 day of downtime, you can change the spell you chose to a different common 2nd-level spell from the same tradition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("398ff1b7-5268-4d6a-9f30-4e6329e12410"), "At least one innate spell gained from an elf ancestry feat.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f3e84ec-381c-43e6-8659-ddc7879d2235"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
