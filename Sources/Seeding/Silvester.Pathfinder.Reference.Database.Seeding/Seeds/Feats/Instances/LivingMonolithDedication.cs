using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LivingMonolithDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("b04902b8-887e-44fd-bad2-587739876c45");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Living Monolith Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the living monolith archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a378743-da8c-47ac-8f63-7f13dfc518ad"), Type = TextBlockType.Text, Text = "~ Access: You are from the Golden Road region." };
            yield return new TextBlock { Id = Guid.Parse("3135bfa2-1916-4756-95e6-a1a5963d3fbf"), Type = TextBlockType.Text, Text = "You’ve begun to inscribe a magical stone called a ka stone that you will someday tie to your soul. You gain knowledge of Ancient Osirion and a connection to your nascent ka stone. If you fail a recovery check while dying, your dying condition does not increase; if you critically fail, your dying condition increases by only 1. You become trained in Ancient Osirion Lore, or expert if you were already trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificLanguage(Guid.Parse("19b5534f-889e-47ac-a95d-04f4b7e96fde"), Languages.Instances.Osiriani.ID);
            builder.HaveSpecificLanguage(Guid.Parse("7c69ceec-761e-4b60-8e07-3192c4fdcad4"), Languages.Instances.Sphinx.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("19e06ec9-ba22-43bd-b6aa-6a9c4ea5d782"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("733a2c08-d379-4e74-8b9e-b4f3ba79ba1e"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
