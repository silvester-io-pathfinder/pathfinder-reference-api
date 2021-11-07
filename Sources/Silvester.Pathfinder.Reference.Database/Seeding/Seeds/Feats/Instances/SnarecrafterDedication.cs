using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnarecrafterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("0648083b-47aa-4a77-a5ad-d785893aa83f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snarecrafter Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "The feat counts as (feat: Snare Specialist) for the purpose of feat prerequisites. If you also have the (feat: Snare Specialist) ranger feat, the quick snares from both feats are cumulative. You can't select another dedication feat until you have gained two other feats from the snarecrafter archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2ea02dd4-cc1b-4188-a4cf-ef6e36fcfacd"), Type = TextBlockType.Text, Text = "You’ve learned to create a limited number of snares at no cost. Each day during your daily preparations, you can prepare four snares from your (item: formula book) for quick deployment; if they normally take 1 minute to (action: Craft), you can (action: Craft) them with 3 (action: Interact) actions. The number of snares increases to six if you’re a master in Crafting and eight if you’re legendary. Snares prepared in this way don’t cost you any resources to (action: Craft)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2e4e94bf-d165-46b8-b320-16cc33fd737d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a04074da-6243-4810-bb43-9323d557cdd5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
