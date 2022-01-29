using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VivaciousConduit : Template
    {
        public static readonly Guid ID = Guid.Parse("3da777b8-c7d8-4511-93ed-dc01c574b89b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vivacious Conduit",
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
            yield return new TextBlock { Id = Guid.Parse("e9376c53-e6b9-434e-b4a9-bdee49bd4912"), Type = TextBlockType.Text, Text = $"Your connection to the First World has grown, and its positive energy flows into you rapidly. If you rest for 10 minutes, you gain Hit Points equal to your Constitution modifier &#215; half your level. This is cumulative with any healing you receive from {ToMarkdownLink<Models.Entities.SkillAction>("Treat Wounds", SkillActions.Instances.TreatWounds.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb0021e8-e306-45e2-9180-82f30d2cfff7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
