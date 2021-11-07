using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickSnares : Template
    {
        public static readonly Guid ID = Guid.Parse("21de795c-b054-430c-8a80-89b41dc17637");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Snares",
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
            yield return new TextBlock { Id = Guid.Parse("c92ac099-aa61-486d-9774-5899c15285ac"), Type = TextBlockType.Text, Text = "You can rig a snare in only moments. You can (action: Craft) snares that normally take 1 minute to (action: Craft) with 3 (action: Interact) actions, even if you haven’t prepared them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1fea26b2-9e14-4610-a1ac-e2d32fb81fda"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("faac422a-1c88-45d2-8006-dd67b4a5b1b5"), Feats.Instances.SnarecrafterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a950008-5c71-4013-936a-9023d1841167"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
