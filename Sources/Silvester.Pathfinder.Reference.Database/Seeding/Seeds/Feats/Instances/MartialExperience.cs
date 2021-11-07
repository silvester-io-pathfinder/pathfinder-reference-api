using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MartialExperience : Template
    {
        public static readonly Guid ID = Guid.Parse("30104fc2-e1e2-4f27-8ba8-0fdb19b272a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Martial Experience",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f300a45b-8630-4492-b233-90ccd5391165"), Type = TextBlockType.Text, Text = "You’ve crossed blades with a wide variety of foes wielding a wide variety of weapons, and you’ve learned the basics of fighting with nearly any of them. When wielding a weapon you aren’t proficient with, treat your level as your proficiency bonus." };
            yield return new TextBlock { Id = Guid.Parse("3a959b5c-342c-4627-bdc0-01c1e34ea89e"), Type = TextBlockType.Text, Text = "At 11th level, you become trained in all weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c28605da-6f27-441b-a7b4-a6a4a115c541"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
