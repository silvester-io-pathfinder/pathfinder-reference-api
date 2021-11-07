using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KitsuneSpellMysteries : Template
    {
        public static readonly Guid ID = Guid.Parse("b1029217-6c58-45ed-9d4e-9ed15934707b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kitsune Spell Mysteries",
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
            yield return new TextBlock { Id = Guid.Parse("b0566db0-c6ee-4e8a-8d91-2b3a7253b4e1"), Type = TextBlockType.Text, Text = "You know more kitsune magic. During your daily preparations, choose (spell: bane), (spell: illusory object), or (spell: sanctuary). You can cast this as a 1st-level divine innate spell once that day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("53a5a609-34a8-4c59-9ea4-2c84a4a8b5d7"), "At least one innate spell from a kitsune heritage or ancestry feat.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b90bf97-e296-45c1-abff-7400bca3fb86"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
